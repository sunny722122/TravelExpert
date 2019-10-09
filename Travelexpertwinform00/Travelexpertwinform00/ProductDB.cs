using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class ProductDB
    {
        public ProductDB()
        {

        }

        public static Products GetProductsbyID(int ProdID)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Products where ProductId=@ProdID";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@ProdID", ProdID);

            try
            {
                conn.Open();
                SqlDataReader prodreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (prodreader.Read())
                {
                    Products prod = new Products();
                    prod.nProdId = (int)prodreader["ProductId"];
                    prod.strProdName = (string)prodreader["ProdName"];
                    return prod;
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

        public static Products GetProductsbyName(string Prodname)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Products where ProdName=@Prodname";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@Prodname", Prodname);

            try
            {
                conn.Open();
                SqlDataReader prodreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (prodreader.Read())
                {
                    Products prod = new Products();
                    prod.nProdId = (int)prodreader["ProductId"];
                    prod.strProdName = (string)prodreader["ProdName"];
                    return prod;
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

        public static bool CheckProductsExistbyName(string Prodname)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "select * from Products where ProdName=@Prodname";
            SqlCommand selcmd = new SqlCommand(strcmd, conn);
            selcmd.Parameters.AddWithValue("@Prodname", Prodname);

            try
            {
                conn.Open();
                SqlDataReader prodreader = selcmd.ExecuteReader(CommandBehavior.SingleRow);
                if (prodreader.Read())
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

        public static int AddProduct(Products prod)
        {
            SqlConnection conn = Connection.GetConnection();
            string strcmd = "insert Products " +
                "(ProdName) " +
                "values(@Prodname)";
            SqlCommand insertcmd = new SqlCommand(strcmd, conn);
            insertcmd.Parameters.AddWithValue("@Prodname", prod.strProdName);

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

        public static bool UpdateProduct(Products oldprod, Products newprod)
        {
            SqlConnection conn = Connection.GetConnection();
            string strupdatecmd = "update Products set " +
                "ProdName=@Prodname " +
                "where ProductId=@ProdID";
            SqlCommand updatecmd = new SqlCommand(strupdatecmd, conn);
            updatecmd.Parameters.AddWithValue("@Prodname", newprod.strProdName);
            updatecmd.Parameters.AddWithValue("@ProdID", oldprod.nProdId);

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

        public static bool DeleteProduct(Products prod)
        {
            SqlConnection conn = Connection.GetConnection();
            string strdelcmd = "delete from Products " +
                "where ProductId=@ProdID or ProdName=@Prodname";
            SqlCommand delcmd = new SqlCommand(strdelcmd, conn);
            delcmd.Parameters.AddWithValue("@ProdID", prod.nProdId);
            delcmd.Parameters.AddWithValue("@Prodname", prod.strProdName);

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
            string strcmd = "select * from Products";
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
