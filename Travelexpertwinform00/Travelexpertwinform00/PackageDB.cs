using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class PackageDB
    {
        public PackageDB()
        {

        }

        public static int GetPackageID(string strpkgname)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select PackageId from Packages where PkgName=@Pkgname";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@Pkgname", strpkgname);

            try
            {
                conn.Open();
                SqlDataReader pkgreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (pkgreader.Read())
                {
                    Package pkg = new Package();
                    pkg.nPkgId = (int)pkgreader["PackageId"];
                    return pkg.nPkgId;
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

        public static Package GetPackages(int npkgId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Packages where PackageId=@PkgId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@PkgId", npkgId);

            try
            {
                conn.Open();
                SqlDataReader pkgreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (pkgreader.Read())
                {
                    Package pkg = new Package();
                    pkg.nPkgId = (int)pkgreader["PackageId"];
                    pkg.PkgName = (string)pkgreader["PkgName"];
                    pkg.pkgStDate = (DateTime)pkgreader["PkgStartDate"];
                    pkg.pkgEndDate = (DateTime)pkgreader["PkgEndDate"];
                    pkg.pkgDesc = (string)pkgreader["PkgDesc"];
                    pkg.pkgBasePrice = (double)pkgreader["PkgBasePrice"];
                    pkg.pkgAgentCom = (double)pkgreader["PkgAgencyCommission"];
                    return pkg;
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

        public static bool CheckPackIdExist(int npkgId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Packages where PackageId=@PkgId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@PkgId", npkgId);

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
        public static int AddPackage(Package pkg)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "insert Packages " + "(PkgName,PkgStartDate,PkgEndDate,PkgDesc,PkgBasePrice,PkgAgencyCommission) " +
                "values(@PkgName,@PkgStDate,@PkgEndDate,@PkgDesc,@PkgBasePrice,@PkgAgenComm)";
            SqlCommand insertcmd = new SqlCommand(strcmd, conn);
            insertcmd.Parameters.AddWithValue("@PkgName", pkg.PkgName);
            insertcmd.Parameters.AddWithValue("@PkgStDate", pkg.pkgStDate);
            insertcmd.Parameters.AddWithValue("@PkgEndDate", pkg.pkgEndDate);
            insertcmd.Parameters.AddWithValue("@PkgDesc", pkg.pkgDesc);
            insertcmd.Parameters.AddWithValue("@PkgBasePrice", pkg.pkgBasePrice);
            insertcmd.Parameters.AddWithValue("@PkgAgenComm", pkg.pkgAgentCom);

            try
            {
                conn.Open();
                insertcmd.ExecuteNonQuery();
                string strselcmd = "select IDENT_CURRENT('Packages') FROM Packages";
                SqlCommand selectCommand =
                    new SqlCommand(strselcmd, conn);
                int pkgID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return pkgID;
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

        public static bool UpdatePkg(Package oldpkg, Package newpkg)
        {
            SqlConnection conn = Connection.GetConnection();
            string strupdatecmd = "update Packages set " +
                "PkgName=@PkgName," +
                "PkgStartDate=@PkgStDate," +
                "PkgEndDate=@PkgEndDate," +
                "PkgDesc=@PkgDesc," +
                "PkgBasePrice=@Pkgbaseprice," +
                "PkgAgencyCommission=@PkgAgenComm " +
                "where PackageId=@PkgId";
            SqlCommand updatecmd = new SqlCommand(strupdatecmd, conn);
            updatecmd.Parameters.AddWithValue("@PkgName", newpkg.PkgName);
            updatecmd.Parameters.AddWithValue("@PkgStDate", newpkg.pkgStDate);
            updatecmd.Parameters.AddWithValue("@PkgEndDate", newpkg.pkgEndDate);
            updatecmd.Parameters.AddWithValue("@PkgDesc", newpkg.pkgDesc);
            updatecmd.Parameters.AddWithValue("@Pkgbaseprice", newpkg.pkgBasePrice);
            updatecmd.Parameters.AddWithValue("@PkgAgenComm", newpkg.pkgAgentCom);
            updatecmd.Parameters.AddWithValue("@PkgId", oldpkg.nPkgId);

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

        public static bool DeletePackage(Package pkg)
        {
            SqlConnection conn = Connection.GetConnection();
            string strdelcmd = "Delete from Packages " +
                "where PackageId=@PkgID";
            SqlCommand delcmd = new SqlCommand(strdelcmd, conn);
            delcmd.Parameters.AddWithValue("@PkgID", pkg.nPkgId);
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

        public static DataTable GetAllPkg()
        {
            string strquery = "select * from Packages order by PackageId asc";
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(strquery, conn);
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
