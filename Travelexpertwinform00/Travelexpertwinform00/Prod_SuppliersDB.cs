using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class Prod_SuppliersDB
    {
        public Prod_SuppliersDB()
        {

        }

        public static Prod_Suppliers GetProd_SupbyProdId(int ProdSupID)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Products_Suppliers " +
                " where ProductSupplierId=@ProdSupID "+
                "order by ProductSupplierId asc";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@ProdSupID", ProdSupID);

            try
            {
                conn.Open();
                SqlDataReader prodsupreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if(prodsupreader.Read())
                {
                    Prod_Suppliers prod_Suppliers = new Prod_Suppliers();
                    prod_Suppliers.nProdSupId = (int)prodsupreader["ProductSupplierId"];
                    prod_Suppliers.nProdId=(int)prodsupreader["ProductId"];
                    prod_Suppliers.nSupId=(int)prodsupreader["SupplierId"];
                    return prod_Suppliers;
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

        public static DataTable GetProd_SupbyPsId(int ProdID,int supId)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Products_Suppliers " +
                " where ProductId=@ProdID and SupplierId=@SupId "+
                "order by ProductSupplierId asc";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@ProdID", ProdID);
            selcmd.Parameters.AddWithValue("@SupId", supId);

            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                return dtbl;
                
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

        public static int AddRecord(Prod_Suppliers prodsup)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "insert Products_Suppliers " +
                "(ProductId,SupplierId) " +
                "values(@ProdID,@SupID)";
            SqlCommand insertcmd = new SqlCommand(strcmd, conn);
            //insertcmd.Parameters.AddWithValue("@prodsupID", prodsup.nProdSupId);
            insertcmd.Parameters.AddWithValue("@ProdID", prodsup.nProdId);
            insertcmd.Parameters.AddWithValue("@SupID", prodsup.nSupId);

            try
            {
                conn.Open();
                insertcmd.ExecuteNonQuery();
                string strselcmd = "select IDENT_CURRENT('Products_Suppliers') FROM Products_Suppliers";
                SqlCommand selectCommand =
                    new SqlCommand(strselcmd, conn);
                int prodsupID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return prodsupID;
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

        public static bool UpdateRecord(Prod_Suppliers oldrec,Prod_Suppliers newrec)
        {
            SqlConnection conn = Connection.GetConnection();
            string strupdatecmd = "update Products_Suppliers set " +
                "ProductId=@ProdID, " +
                "SupplierId=@SupID " +
                "where ProductSupplierId=@Prod_SupID";
            SqlCommand updatecmd = new SqlCommand(strupdatecmd, conn);
            updatecmd.Parameters.AddWithValue("@ProdID", newrec.nProdId);
            updatecmd.Parameters.AddWithValue("@SupID", newrec.nSupId);
            updatecmd.Parameters.AddWithValue("@Prod_SupID", oldrec.nProdSupId);

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

        public static bool DeleteRec(Prod_Suppliers prodsup)
        {
            SqlConnection conn = Connection.GetConnection();
            string strdelcmd = "Delete from Products_Suppliers " +
                "where ProductSupplierId=@prod_supID";
            SqlCommand delcmd = new SqlCommand(strdelcmd, conn);
            delcmd.Parameters.AddWithValue("prod_supID", prodsup.nProdSupId);

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
            string strcmd = "select * from Products_Suppliers "+
                "order by ProductSupplierId asc";
            using (SqlConnection conn=Connection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(strcmd, conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                return dtbl;
            }
        }

        public static DataTable GetSupsData(string prodname)
        {
            string strcmd = "select Suppliers.SupName "+
                "from Suppliers "+
                "join Products_Suppliers on Products_Suppliers.SupplierId = Suppliers.SupplierId "+
                "join Products on Products_Suppliers.ProductId = Products.ProductId "+
                "where Products.ProdName = @ProdName "+
                "order by ProductSupplierId asc";
            using (SqlConnection conn = Connection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(strcmd, conn);
                cmd.Parameters.AddWithValue("ProdName", prodname);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                return dtbl;
            }
        }

        public static DataTable GetAllDatabyName()
        {
            string strcmd = "select Products_Suppliers.ProductSupplierId,Products.ProdName, Suppliers.SupName " +
                "from Products_Suppliers " +
                "join Suppliers on Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                "join Products on Products_Suppliers.ProductId = Products.ProductId "+
                "order by ProductSupplierId asc";
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
    }
}
