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
    public partial class ProdSupFrm : Form
    {
        public ProdSupFrm()
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

        private void ProdSupFrm_Load(object sender, EventArgs e)
        {
            BindingSource psbindsource = new BindingSource();
            psbindsource.DataSource = Prod_SuppliersDB.GetAllDatabyName();
            bindingNavigatorPS.BindingSource = psbindsource;

            dgvProdSup.DataSource= Prod_SuppliersDB.GetAllDatabyName();
            //DataGridViewButtonColumn updatecol = new DataGridViewButtonColumn();
            //updatecol.Text = "Updates";
            //updatecol.Name = "Update";
            //DataGridViewButtonColumn Delcol = new DataGridViewButtonColumn();
            //Delcol.Text = "Delete";
            //Delcol.Name = "Delete";
            //dgvProdSup.Columns.Add("Update", "Update");
            //dgvProdSup.Columns.Add("Delete", "Delete");

            
            refreshitems();
        }

        private void refreshitems()
        { 
            DataTable dtps =  Prod_SuppliersDB.GetAllDatabyName();

            //bindingNavigatorPS.PositionItem.Text = dtps.Rows.Count.ToString();
            int nindex = Convert.ToInt32(bindingNavigatorPS.PositionItem.Text) - 1;
            if ( nindex < dtps.Rows.Count)
            {
                txtProdSupID.Text = dtps.Rows[nindex]["ProductSupplierId"].ToString();

                cbProducts.DisplayMember = "ProdName";
                cbProducts.ValueMember = "ProductId";
                cbProducts.DataSource = ProductDB.GetData();
                cbSuppliers.DisplayMember = "SupName";
                cbSuppliers.ValueMember = "SupplierId";
                cbSuppliers.DataSource = SupplierDB.GetData();

                cbProducts.Text = dtps.Rows[nindex]["ProdName"].ToString();
                cbSuppliers.Text = dtps.Rows[nindex]["SupName"].ToString();
            }
            //if (dgvProdSup.DataSource==null)
            {
                dgvProdSup.DataSource = Prod_SuppliersDB.GetAllDatabyName();
                
            }
            if (dgvProdSup.DataSource != null)
            {
                for(int i=0;i< dgvProdSup.Rows.Count;i++)
                {
                    dgvProdSup.Rows[i].Selected = false;
                    dgvProdSup.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                if( nindex< dgvProdSup.Rows.Count)
                {
                    dgvProdSup.Rows[nindex].Selected = true;
                    dgvProdSup.Rows[nindex].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                
            }
            

        }

        private void BindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            BindingSource psbindsource = new BindingSource();
            psbindsource.DataSource = Prod_SuppliersDB.GetAllDatabyName();
            bindingNavigatorPS.BindingSource = psbindsource;

            txtProdSupID.Text = "-1";
            
            //cbProducts.Text = "";
            //cbSuppliers.Text = "";
        }

        private bool Validation()
        {
            if(cbProducts.Text == "")
            {
                lblProdErr.Text = "Product is required!";
                return false;
            }
            else
            {
                lblProdErr.Text = "";
            }

            if (cbSuppliers.Text == "")
            {
                lblSupErr.Text = "Supplier is required!";
                return false;
            }
            else
            {
                lblSupErr.Text = "";
            }
            return true;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            //Save
            if (Validation())
            {
                int nprodId = ProductDB.GetProductsbyName(cbProducts.Text).nProdId;
                int nsupId = SupplierDB.GetSuppliersbyName(cbSuppliers.Text).nSupId;
                Prod_Suppliers ps = new Prod_Suppliers();
                ps.nProdId = nprodId;
                ps.nSupId = nsupId;
                if (txtProdSupID.Text == "-1")
                {
                    if (Prod_SuppliersDB.GetProd_SupbyPsId(nprodId, nsupId).Rows.Count <= 0)
                    {
                        Prod_SuppliersDB.AddRecord(ps);
                    }
                    else
                    {
                        CustMesg msgfrm = new CustMesg();
                        msgfrm.Showmsg("Record exist already!");
                        msgfrm.Show();
                        //MessageBox.Show("Record exist already!");
                    }
                }
                else
                {
                    int prodsupID = Convert.ToInt32(txtProdSupID.Text);
                    ps.nProdSupId = prodsupID;
                    Prod_SuppliersDB.UpdateRecord(ps, ps);
                }
                refreshitems();
                BindingSource psbindsource = new BindingSource();
                psbindsource.DataSource = Prod_SuppliersDB.GetAllDatabyName();
                bindingNavigatorPS.BindingSource = psbindsource;
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                if(txtProdSupID.Text != "-1")
                {
                    int nprodId = ProductDB.GetProductsbyName(cbProducts.Text).nProdId;
                    int nsupId = SupplierDB.GetSuppliersbyName(cbSuppliers.Text).nSupId;
                    Prod_Suppliers ps = new Prod_Suppliers();
                    ps.nProdId = nprodId;
                    ps.nSupId = nsupId;
                    int prodsupID = Convert.ToInt32(txtProdSupID.Text);
                    ps.nProdSupId = prodsupID;
                    if (!Pkg_Product_SuppliersDB.CheckDataInusebyPSID(prodsupID) && !BookingDetailsDB.CheckProdSupInuse(prodsupID))
                    {
                        Prod_SuppliersDB.DeleteRec(ps);
                        refreshitems();
                    }
                    else
                    {
                        CustMesg custMesg = new CustMesg();
                        custMesg.Showmsg("The Product_Supplier record is in use in Pkg_Product_Supplier table,\n Please delete record in Pkg_Product_Supplier table first!");
                        custMesg.Show();
                        refreshitems();
                        BindingSource psbindsource = new BindingSource();
                        psbindsource.DataSource = Prod_SuppliersDB.GetAllDatabyName();
                        bindingNavigatorPS.BindingSource = psbindsource;
                    }
                }
                else
                {
                    CustMesg msgfrm = new CustMesg();
                    msgfrm.Showmsg("Not a valid record!");
                    msgfrm.Show();
                    refreshitems();
                    BindingSource psbindsource = new BindingSource();
                    psbindsource.DataSource = Prod_SuppliersDB.GetAllDatabyName();
                    bindingNavigatorPS.BindingSource = psbindsource;
                    //MessageBox.Show("Not a valid record!");
                }
            }
            else
            {
                refreshitems();
                BindingSource psbindsource = new BindingSource();
                psbindsource.DataSource = Prod_SuppliersDB.GetAllDatabyName();
                bindingNavigatorPS.BindingSource = psbindsource;
            }
        }

        private void BindingNavigatorPS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ////Save
            //if (Validation())
            //{
            //    int nprodId = ProductDB.GetProductsbyName(cbProducts.Text).nProdId;
            //    int nsupId = SupplierDB.GetSuppliersbyName(cbSuppliers.Text).nSupId;
            //    Prod_Suppliers ps = new Prod_Suppliers();
            //    ps.nProdId = nprodId;
            //    ps.nSupId = nsupId;
            //    if (txtProdSupID.Text == "-1")
            //    {
            //        if (Prod_SuppliersDB.GetProd_SupbyPsId(nprodId, nsupId).Rows.Count <= 0)
            //        {
            //            Prod_SuppliersDB.AddRecord(ps);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Record exist already!");
            //        }
            //    }
                
            //    refreshitems();
            //}
        }
    }
}
