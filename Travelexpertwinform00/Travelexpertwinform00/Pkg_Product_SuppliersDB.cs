using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class Pkg_Product_SuppliersDB
    {
        public Pkg_Product_SuppliersDB()
        {

        }

        public static Pkg_Product_Suppliers GetDatabyPkgID(int pkgId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Packages_Products_Suppliers where PackageId=@pkgId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@pkgId", pkgId);

            try
            {
                conn.Open();
                SqlDataReader datareader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (datareader.Read())
                {
                    Pkg_Product_Suppliers pkgprodsup = new Pkg_Product_Suppliers();
                    pkgprodsup.pkgId = (int)datareader["PackageId"];
                    pkgprodsup.prodSupId = (int)datareader["ProductSupplierId"];
                    return pkgprodsup;
                }
                else
                    return null;
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

        public static bool CheckDatabyPkgID(int pkgId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Packages_Products_Suppliers where PackageId=@pkgId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@pkgId", pkgId);

            try
            {
                conn.Open();
                SqlDataReader datareader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (datareader.Read())
                {
                    
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

        public static Pkg_Product_Suppliers GetDatabyPSID(int prodsupId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Packages_Products_Suppliers where ProductSupplierId=@prodsupId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@prodsupId", prodsupId);

            try
            {
                conn.Open();
                SqlDataReader datareader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (datareader.Read())
                {
                    Pkg_Product_Suppliers pkgprodsup = new Pkg_Product_Suppliers();
                    pkgprodsup.pkgId = (int)datareader["PackageId"];
                    pkgprodsup.prodSupId = (int)datareader["ProductSupplierId"];
                    return pkgprodsup;
                }
                else
                    return null;
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

        public static bool CheckDataInusebyPSID(int prodsupId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Packages_Products_Suppliers where ProductSupplierId=@prodsupId";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@prodsupId", prodsupId);

            try
            {
                conn.Open();
                SqlDataReader datareader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (datareader.Read())
                {
                   
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
        public static int AddPPSData(Pkg_Product_Suppliers pps)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "insert Packages_Products_Suppliers " +
                "(PackageId, ProductSupplierId) " +
                "values(@pkgId,@ProdSupID)";
            SqlCommand insertcmd = new SqlCommand(strcmd, conn);
            insertcmd.Parameters.AddWithValue("@pkgId", pps.pkgId);
            insertcmd.Parameters.AddWithValue("@ProdSupID", pps.prodSupId);

            try
            {
                conn.Open();
                insertcmd.ExecuteNonQuery();
                //string strselcmd = "select IDENT_CURRENT('Packages_Products_Suppliers') FROM Packages_Products_Suppliers";
                //SqlCommand selectCommand =
                //    new SqlCommand(strselcmd, conn);
                //int ppsID = Convert.ToInt32(selectCommand.ExecuteScalar());
                //return ppsID;
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

        public static bool UpdatePkgData(Pkg_Product_Suppliers oldpps,Pkg_Product_Suppliers newpps)
        {
            SqlConnection conn = Connection.GetConnection();
            string strupdatecmd = "update Packages_Products_Suppliers set " +
                "PackageId=@pkgId " +
                "where ProductSupplierId=@prodsupId";
            SqlCommand updatecmd = new SqlCommand(strupdatecmd, conn);
            updatecmd.Parameters.AddWithValue("@pkgId", newpps.pkgId);
            updatecmd.Parameters.AddWithValue("@prodsupId", oldpps.prodSupId);

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

        public static bool UpdateProdSupData(Pkg_Product_Suppliers oldpps, Pkg_Product_Suppliers newpps)
        {
            SqlConnection conn = Connection.GetConnection();
            string strupdatecmd = "update Packages_Products_Suppliers set " +
                "ProductSupplierId=@prodsupId "+
                "where PackageId=@pkgId";
            SqlCommand updatecmd = new SqlCommand(strupdatecmd, conn);
            updatecmd.Parameters.AddWithValue("@pkgId", oldpps.pkgId);
            updatecmd.Parameters.AddWithValue("@prodsupId", newpps.prodSupId);

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


        public static bool DeletePPSbyPkgId(Pkg_Product_Suppliers pps)
        {
            SqlConnection conn = Connection.GetConnection();
            string strdelcmd = "Delete from Packages_Products_Suppliers " +
                "where PackageId=@pkgID";
            SqlCommand delcmd = new SqlCommand(strdelcmd, conn);
            delcmd.Parameters.AddWithValue("@pkgID",pps.pkgId);
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

        public static bool DeletePPSbypps(Pkg_Product_Suppliers pps)
        {
            SqlConnection conn = Connection.GetConnection();
            string strdelcmd = "Delete from Packages_Products_Suppliers " +
                "where PackageId=@pkgID and ProductSupplierId=@ProdSupId";
            SqlCommand delcmd = new SqlCommand(strdelcmd, conn);
            delcmd.Parameters.AddWithValue("@pkgID", pps.pkgId);
            delcmd.Parameters.AddWithValue("@ProdSupId", pps.prodSupId);
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

        public static DataTable GetAllPpsData()
        {
            string strquery = "select * from Packages_Products_Suppliers";
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

        public static DataTable GetAllPsDatabyPkgId(int pkgId)
        {
            string strquery = "select * from Packages_Products_Suppliers "+
                "where PackageId=@PkgId"; 
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(strquery, conn);
                    cmd.Parameters.AddWithValue("@PkgId", pkgId);
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

        public static DataTable GetAllPkgrelatedData()
        {
            string strquery = "select Packages.PkgName,Packages.PkgStartDate,Packages.PkgEndDate,Packages.PkgDesc,Packages.PkgBasePrice,Packages.PkgAgencyCommission,Products.ProdName,Suppliers.SupName "+ 
                "from Packages join Packages_Products_Suppliers on Packages.PackageId = Packages_Products_Suppliers.PackageId "+
                "join Products_Suppliers on Products_Suppliers.ProductSupplierId = Packages_Products_Suppliers.ProductSupplierId "+
                "join Products on Products_Suppliers.ProductId = Products.ProductId " +
                "join Suppliers on Suppliers.SupplierId = Products_Suppliers.SupplierId";
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

        public static DataTable GetAllPkgProductData(int PkgId)
        {
            string strquery = "select Products.ProdName " +
                "from Packages join Packages_Products_Suppliers on Packages.PackageId = Packages_Products_Suppliers.PackageId " +
                "join Products_Suppliers on Products_Suppliers.ProductSupplierId = Packages_Products_Suppliers.ProductSupplierId " +
                "join Products on Products_Suppliers.ProductId = Products.ProductId " +
                "join Suppliers on Suppliers.SupplierId = Products_Suppliers.SupplierId "+
                "where Packages.PackageId=@PkgId";
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(strquery, conn);
                    cmd.Parameters.AddWithValue("@pkgID", PkgId);
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

        public static DataTable GetAllPkgSupData(int PkgId)
        {
            string strquery = "select Suppliers.SupName " +
                "from Packages join Packages_Products_Suppliers on Packages.PackageId = Packages_Products_Suppliers.PackageId " +
                "join Products_Suppliers on Products_Suppliers.ProductSupplierId = Packages_Products_Suppliers.ProductSupplierId " +
                "join Products on Products_Suppliers.ProductId = Products.ProductId " +
                "join Suppliers on Suppliers.SupplierId = Products_Suppliers.SupplierId " +
                "where Packages.PackageId=@PkgId";
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(strquery, conn);
                    cmd.Parameters.AddWithValue("@pkgID", PkgId);
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

        public static DataTable GetAllPkgProdSupData(int PkgId)
        {
            string strquery = "select Products.ProdName,Suppliers.SupName " +
                "from Packages join Packages_Products_Suppliers on Packages.PackageId = Packages_Products_Suppliers.PackageId " +
                "join Products_Suppliers on Products_Suppliers.ProductSupplierId = Packages_Products_Suppliers.ProductSupplierId " +
                "join Products on Products_Suppliers.ProductId = Products.ProductId " +
                "join Suppliers on Suppliers.SupplierId = Products_Suppliers.SupplierId " +
                "where Packages.PackageId=@PkgId";
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(strquery, conn);
                    cmd.Parameters.AddWithValue("@pkgID", PkgId);
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
