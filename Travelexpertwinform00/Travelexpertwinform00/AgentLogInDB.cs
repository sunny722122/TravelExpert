using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class AgentLogInDB
    {
        public AgentLogInDB()
        {

        }

        public static AgentLogin GetUserbyID(int UserID)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Agents_Login where AgentId=@AgentID";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@AgentID", UserID);

            try
            {
                conn.Open();
                SqlDataReader agentreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (agentreader.Read())
                {
                    AgentLogin agent = new AgentLogin();
                    agent.nAgentId = (int)agentreader["AgentId"];
                    agent.strPassword = (string)agentreader["AgentPwd"];
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

        public static bool CheckIDexist(int userId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Agents_Login where AgentId=@AgentID";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@AgentID", userId);

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

        public static bool CheckPwdMatch(AgentLogin agent)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Agents_Login where AgentId=@AgentID";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@AgentID", agent.nAgentId);

            try
            {
                conn.Open();
                SqlDataReader agentreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (agentreader.Read())
                {
                    AgentLogin agenread = new AgentLogin();
                    agenread.strPassword = agentreader["AgentPwd"].ToString();
                    if (agent.strPassword == agenread.strPassword)
                        return true;
                    else
                        return false;
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

        public static int AddAgentLogIn(AgentLogin agent)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "insert Agents_Login " +
                "(AgentId,AgentPwd) " +
                "values(@AgentId,@AgentPwd) ";
            SqlCommand insertcmd = new SqlCommand(strcmd, conn);
            insertcmd.Parameters.AddWithValue("@AgentId", agent.nAgentId);
            insertcmd.Parameters.AddWithValue("@AgentPwd", agent.strPassword);

            try
            {
                conn.Open();
                insertcmd.ExecuteNonQuery();
                return 1;
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

        public static bool UpdateAgentLogin(AgentLogin oldagent, AgentLogin newagent)
        {
            SqlConnection conn = Connection.GetConnection();
            string strupdatecmd = "update Agents_Login set " +
                "AgentPwd=@AgentPwd " +
                "where AgentId=@AgentID";
            SqlCommand updatecmd = new SqlCommand(strupdatecmd, conn);
            updatecmd.Parameters.AddWithValue("@AgentPwd", newagent.strPassword);
            updatecmd.Parameters.AddWithValue("@AgentID", oldagent.nAgentId);

            try
            {
                conn.Open();
                int count = updatecmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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

        public static bool DeleteRecord(AgentLogin agent)
        {
            SqlConnection conn = Connection.GetConnection();
            string strdelcmd = "delete from Agents_Login " +
                "where AgentId=@AgentID";
            SqlCommand delcmd = new SqlCommand(strdelcmd, conn);
            delcmd.Parameters.AddWithValue("@AgentID", agent.nAgentId);
            

            try
            {
                conn.Open();
                int count = delcmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
