using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class AgentsDB
    {
        public AgentsDB()
        {

        }

        public static Agents GetAgentById(int agtId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Agents where AgentId=@AgentID";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@AgentID", agtId);

            try
            {
                conn.Open();
                SqlDataReader agentreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (agentreader.Read())
                {
                    Agents agent = new Agents();
                    agent.nAgentId = (int)agentreader["AgentId"];
                    agent.AgentFirstName = (string)agentreader["AgtFirstName"];
                    agent.AgentMiddleInitial=(string)agentreader["AgtMiddleInitial"];
                    agent.AgtLastName = Convert.ToString(agentreader["AgtLastName"]);
                    agent.AgtBusPhone= Convert.ToString(agentreader["AgtBusPhone"]);
                    agent.AgtEmail = Convert.ToString(agentreader["AgtEmail"]);
                    agent.AgtPosition = Convert.ToString(agentreader["AgtPosition"]);
                    agent.AgencyId = Convert.ToInt32(agentreader["AgencyId"]);
                    return agent;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                conn.Close();
            }
        }

        public static bool CheckAgentIDExist(int agtId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Agents where AgentId=@AgentID";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@AgentID", agtId);

            try
            {
                conn.Open();
                SqlDataReader agentreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (agentreader.Read())
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                conn.Close();
            }
        }

    }
}
