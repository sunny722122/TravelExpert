using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travelexpertwinform00
{
    public partial class ProductFrm : Form
    {
        public ProductFrm()
        {
            InitializeComponent();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            MainFrm main = new MainFrm();
            if (!FrmValid.checkformopen(main.Text))
            {
                main.Show();
                this.Close();
            }
            else
            {
                main.Activate();
                this.Close();
            }
        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            BindingSource prodbindsource = new BindingSource();
            prodbindsource.DataSource = ProductDB.GetData();
            bindingNavigatorProd.BindingSource = prodbindsource;
            refreshitems();
        }

        private void refreshitems()
        {
            DataTable dtrod = ProductDB.GetData();

            int nindex = Convert.ToInt32(bindingNavigatorProd.PositionItem.Text) - 1;
            if (nindex < dtrod.Rows.Count)
            {
                txtProdId.Text = dtrod.Rows[nindex]["ProductId"].ToString();
                txtProdName.Text = dtrod.Rows[nindex]["ProdName"].ToString();
            }
            
                dgvProducts.DataSource = ProductDB.GetData();


            if (dgvProducts.DataSource != null)
            {
                for (int i = 0; i < dgvProducts.Rows.Count; i++)
                {
                    dgvProducts.Rows[i].Selected = false;
                    dgvProducts.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                if (nindex < dgvProducts.Rows.Count)
                {
                    dgvProducts.Rows[nindex].Selected = true;
                    dgvProducts.Rows[nindex].DefaultCellStyle.BackColor = Color.LightYellow;
                }

            }
        }

        private bool Validation()
        {
            if (txtProdName.Text == "")
            {
                lblProdErr.Text = "Product Name is required!";
                return false;
            }
            else
            {
                lblProdErr.Text = "";
            }
            return true;
        }

        private void BindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            BindingSource prodbindsource = new BindingSource();
            prodbindsource.DataSource = ProductDB.GetData();
            bindingNavigatorProd.BindingSource = prodbindsource;

            txtProdId.Text = "-1";
            txtProdName.Text = "";

        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                if(txtProdId.Text=="-1" ||txtProdId.Text=="")
                {
                    CustMesg msgfrm = new CustMesg();
                    msgfrm.Showmsg("Not a valid Product!");
                    msgfrm.Show();
                    refreshitems();
                    BindingSource prodbindsource = new BindingSource();
                    prodbindsource.DataSource = ProductDB.GetData();
                    bindingNavigatorProd.BindingSource = prodbindsource;
                }
                else
                {
                    int prodId = Convert.ToInt32(txtProdId.Text);
                    Products prod = new Products();
                    prod.nProdId = prodId;
                    prod.strProdName = txtProdName.Text;
                    if(!Prod_SuppliersDB.CheckProdInusebyProdId(prodId))
                    { 
                    ProductDB.DeleteProduct(prod);
                    refreshitems();
                    }
                    else
                    {
                        CustMesg custMesg = new CustMesg();
                        custMesg.Showmsg("The Product is in use in Product_Supplier table,\n Please delete record in Product_Supplier table first!");
                        custMesg.Show();
                        refreshitems();
                        BindingSource prodbindsource = new BindingSource();
                        prodbindsource.DataSource = ProductDB.GetData();
                        bindingNavigatorProd.BindingSource = prodbindsource;
                    }
                }
                
            }
            else
            {
                refreshitems();
                BindingSource prodbindsource = new BindingSource();
                prodbindsource.DataSource = ProductDB.GetData();
                bindingNavigatorProd.BindingSource = prodbindsource;
            }
        }

        private void ToolStripBtnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if(txtProdId.Text != "")
                {
                    int prodId = Convert.ToInt32(txtProdId.Text);
                    Products prod = new Products();
                    prod.nProdId = prodId;
                    prod.strProdName = txtProdName.Text;
                    if (txtProdId.Text == "-1")
                    {
                        //insert new
                        if(ProductDB.CheckProductsExistbyName(txtProdName.Text))
                        {
                            CustMesg msgfrm = new CustMesg();
                            msgfrm.Showmsg("Products Exist already!");
                            msgfrm.Show();
                            //MessageBox.Show("Products Exist already!");
                        }
                        else
                        {
                            ProductDB.AddProduct(prod);
                        }
                        
                    }
                    else
                    {
                        //update
                        
                        ProductDB.UpdateProduct(prod,prod);
                    }
                    refreshitems();

                    BindingSource prodbindsource = new BindingSource();
                    prodbindsource.DataSource = ProductDB.GetData();
                    bindingNavigatorProd.BindingSource = prodbindsource;
                }
                
            }
        }
    }
}
