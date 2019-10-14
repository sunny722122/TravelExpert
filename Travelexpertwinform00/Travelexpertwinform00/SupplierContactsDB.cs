using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class SupplierContactsDB
    {
        public static bool CheckSupplierInuse(int supId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from SupplierContacts " +
                " where SupplierId=@SupId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);

            selcmd.Parameters.AddWithValue("@SupId", supId);

            try
            {
                conn.Open();
                // int count = selcmd.ExecuteNonQuery();
                SqlDataReader datareader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (datareader.Read())
                {
                    // if (count > 0)
                    return true;
                }
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
