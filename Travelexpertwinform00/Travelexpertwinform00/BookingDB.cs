using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class BookingDB
    {
        public BookingDB()
        {

        }

        public static bool CheckPackageIdInuse(int pkgId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Bookings where PackageId=@PkgId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@PkgId", pkgId);

            try
            {
                conn.Open();
                SqlDataReader pkgreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (pkgreader.Read())
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
