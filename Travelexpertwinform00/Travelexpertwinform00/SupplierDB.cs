using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class SupplierDB
    {
        public SupplierDB()
        {

        }

        public static Suppliers GetSuppliersbyID(int SupID)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Suppliers where SupplierId=@SupID";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@SupID", SupID);

            try
            {
                conn.Open();
                SqlDataReader supreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (supreader.Read())
                {
                    Suppliers sup = new Suppliers();
                    sup.nSupId = (int)supreader["SupplierId"];
                    sup.strSupName = (string)supreader["SupName"];
                    return sup;
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

        public static int GetMaxSuppliersID()
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select MAX( SupplierId) as MaxSupId from Suppliers";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            
            try
            {
                conn.Open();
                SqlDataReader supreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (supreader.Read())
                {
                    Suppliers sup = new Suppliers();
                    sup.nSupId = (int)supreader["MaxSupId"];
                    
                    return sup.nSupId;
                }
                else
                {
                    return 0;
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

        public static Suppliers GetSuppliersbyName(string supname)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Suppliers where SupName=@Supname";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@Supname", supname);

            try
            {
                conn.Open();
                SqlDataReader supreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (supreader.Read())
                {
                    Suppliers sup = new Suppliers();
                    sup.nSupId = (int)supreader["SupplierId"];
                    sup.strSupName = (string)supreader["SupName"];
                    return sup;
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

        public static bool CheckSuppliersExistbyName(string supname)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Suppliers where SupName=@Supname";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@Supname", supname);

            try
            {
                conn.Open();
                SqlDataReader supreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (supreader.Read())
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

        public static int AddSupplier(Suppliers sup)
        {
            int supId = GetMaxSuppliersID();
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "insert Suppliers " +
                "(SupplierId,SupName) " +
                "values(@SupId,@Supname)";
            SqlCommand insertcmd = new SqlCommand(strcmd, conn);
            insertcmd.Parameters.AddWithValue("@Supname", sup.strSupName);
            if(supId > 0)
            {
                insertcmd.Parameters.AddWithValue("@SupId", supId+1);
            }
            else
            {
                insertcmd.Parameters.AddWithValue("@SupId", 1);
            }
            

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

        public static bool UpdateSupplier(Suppliers oldsup, Suppliers newsup)
        {
            SqlConnection conn = Connection.GetConnection();
            string strupdatecmd = "update Suppliers set " +
                "SupName=@Supname " +
                "where SupplierId=@SupID";
            SqlCommand updatecmd = new SqlCommand(strupdatecmd, conn);
            updatecmd.Parameters.AddWithValue("@Supname", newsup.strSupName);
            updatecmd.Parameters.AddWithValue("@SupID", oldsup.nSupId);

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

        public static bool DeleteSupplier(Suppliers sup)
        {
            SqlConnection conn = Connection.GetConnection();
            string strdelcmd = "delete from Suppliers " +
                "where SupplierId=@SupID or SupName=@Supname";
            SqlCommand delcmd = new SqlCommand(strdelcmd, conn);
            delcmd.Parameters.AddWithValue("@SupID", sup.nSupId);
            delcmd.Parameters.AddWithValue("@Supname", sup.strSupName);

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

        public static DataTable GetData()
        {
            string strcmd = "select * from Suppliers order by SupplierId asc ";
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(strcmd, conn);
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    return dtbl;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ;
            }
        }
    }
}
