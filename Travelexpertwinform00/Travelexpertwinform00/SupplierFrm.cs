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
    public partial class SupplierFrm : Form
    {
        public SupplierFrm()
        {
            InitializeComponent();
        }

        private void BtnRet_Click(object sender, EventArgs e)
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

        private void SupplierFrm_Load(object sender, EventArgs e)
        {
            BindingSource supbindsource = new BindingSource();
            supbindsource.DataSource = SupplierDB.GetData();
            bindingNavigatorSup.BindingSource = supbindsource;
            refreshitems();
        }

        private void refreshitems()
        {
            DataTable dtsup = SupplierDB.GetData();

            int nindex = Convert.ToInt32(bindingNavigatorSup.PositionItem.Text) - 1;
            txtSupId.Text = dtsup.Rows[nindex]["SupplierId"].ToString();
            txtSupName.Text = dtsup.Rows[nindex]["SupName"].ToString();


            dgvSups.DataSource = SupplierDB.GetData();


            if (dgvSups.DataSource != null)
            {
                for (int i = 0; i < dgvSups.Rows.Count; i++)
                {
                    dgvSups.Rows[i].Selected = false;
                    dgvSups.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                if (nindex < dgvSups.Rows.Count)
                {
                    dgvSups.Rows[nindex].Selected = true;
                    dgvSups.Rows[nindex].DefaultCellStyle.BackColor = Color.LightYellow;
                }

            }
        }

        private bool Validation()
        {
            if (txtSupName.Text == "")
            {
                lblSupNameErr.Text = "Supplier Name is required!";
                return false;
            }
            else
            {
                lblSupNameErr.Text = "";
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
            txtSupId.Text = "-1";
            txtSupName.Text = "";
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (txtSupId.Text == "-1" || txtSupId.Text == "")
                {
                    MessageBox.Show("Not a valid Supplier!");
                }
                else
                {
                    int supId = Convert.ToInt32(txtSupId.Text);
                    Suppliers sup = new Suppliers();
                    sup.nSupId = supId;
                    sup.strSupName = txtSupName.Text;
                    SupplierDB.DeleteSupplier(sup);
                    refreshitems();
                }
            }
        }

        private void ToolStripBtnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (txtSupId.Text != "")
                {
                    int supId = Convert.ToInt32(txtSupId.Text);
                    Suppliers sup = new Suppliers();
                    sup.nSupId = supId;
                    sup.strSupName = txtSupName.Text;
                    if (txtSupId.Text == "-1")
                    {
                        //insert new
                        if(SupplierDB.CheckSuppliersExistbyName(txtSupName.Text))
                        {
                            MessageBox.Show("Supplier exist already!");
                        }
                        else
                        {
                            SupplierDB.AddSupplier(sup);
                        }
                        
                    }
                    else
                    {
                        //update
                        
                        SupplierDB.UpdateSupplier(sup, sup);
                    }
                    refreshitems();
                }
            }
        }
    }
}
