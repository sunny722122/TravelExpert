using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class BookingDetailsDB
    {
        public static bool CheckProdSupInuse(int prodsupId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from BookingDetails " +
                " where ProductSupplierId=@ProdsupId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);

            selcmd.Parameters.AddWithValue("@ProdsupId", prodsupId);

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
