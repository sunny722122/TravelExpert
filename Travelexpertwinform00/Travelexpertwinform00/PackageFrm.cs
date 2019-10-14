using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Travelexpertwinform00
{
    public partial class PackageFrm : Form
    {
       
        public PackageFrm()
        {
            
            InitializeComponent();
            BindingSource pkgbindsource = new BindingSource();
            pkgbindsource.DataSource = PackageDB.GetAllPkg();
            PackagesBindingNavigator.BindingSource = pkgbindsource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbProducts.DisplayMember = "ProdName";
            cbProducts.ValueMember = "ProductId";
            cbProducts.DataSource = ProductDB.GetData();

            //refreshsups();

            refreshitems();
            Validation();
        }

        private void refreshsups()
        {
            if (cbProducts.Text != "")
            {
                cbSups.DisplayMember = "SupName";
                cbSups.ValueMember = "SupplierId";
                cbSups.DataSource = Prod_SuppliersDB.GetSupsData(cbProducts.Text);
                //cbSups.DataBindings.Add(new System.Windows.Forms.Binding("Text", Prod_SuppliersDB.GetSupsData(cbProducts.Text), "SupName", true));
            }
        }

        private bool Validation()
        {
            if (pkgNameTextBox.Text == "")
            {
                lblPkgnameErr.Text = "Package Name is required!";
                return false;
            }
            else
            {
                lblPkgnameErr.Text = "";
            }

            if (pkgNameTextBox.Text.Length > 50)
            {
                lblPkgnameErr.Text = "Package Name length must be less than 50 characters!";
                pkgNameTextBox.Text = "";
                return false;
            }
            else
            {
                lblPkgnameErr.Text = "";
            }

            if (pkgBasePriceTextBox.Text == "")
            {
                lblPkgBasePriceErr.Text = "Package Base Price required!";
                return false;
            }
            else
            {
                lblPkgBasePriceErr.Text = "";
            }

            if (pkgAgencyCommissionTextBox.Text != "")
            {
                if (Convert.ToDouble(pkgAgencyCommissionTextBox.Text) > Convert.ToDouble(pkgBasePriceTextBox.Text))
                {
                    lblPkgAgentComErr.Text = "Package Agency Commission can't be higher than base price!";
                    pkgAgencyCommissionTextBox.Text = "";
                    return false;
                }
                else
                {
                    lblPkgAgentComErr.Text = "";
                }
            }

            if (pkgStartDateDateTimePicker.Value >= pkgEndDateDateTimePicker.Value)
            {
                lblPkgEndDateErr.Text = "Package end date must be later than start date!";
                //pkgEndDateDateTimePicker.Value = pkgStartDateDateTimePicker.Value;
                return false;
            }
            else
            {
                lblPkgEndDateErr.Text = "";
            }

            if (pkgStartDateDateTimePicker.Value < DateTime.Now)
            {
                lblPkgstDateErr.Text = "Package start date must be later than current date!";
               // pkgStartDateDateTimePicker.Value = DateTime.Now;
                return false;
            }
            else
            {
                lblPkgstDateErr.Text = "";
            }
            //if(dgvPkgProd.Rows.Count<=1)
            //{
            //    lblProductErr.Text = "Products is required!";
            //    return false;
            //}

           
            return true;
        }

        private void PackagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Package pkg = new Package();
                pkg.PkgName = pkgNameTextBox.Text;
                pkg.pkgStDate = pkgStartDateDateTimePicker.Value;
                pkg.pkgEndDate = pkgEndDateDateTimePicker.Value;
                pkg.pkgDesc = pkgDescTextBox.Text;
                pkg.pkgBasePrice = Convert.ToDouble(pkgBasePriceTextBox.Text);
                pkg.pkgAgentCom = Convert.ToDouble(pkgAgencyCommissionTextBox.Text);
                PackageDB.AddPackage(pkg);
                this.Validate();
            }
            

        }

        private void refreshitems()
        {
            DataTable dtpkg = PackageDB.GetAllPkg();
            
            int nindex =Convert.ToInt32( PackagesBindingNavigator.PositionItem.Text)-1;
            packageIdTextBox.Text= dtpkg.Rows[nindex]["PackageId"].ToString();
            pkgNameTextBox.Text= dtpkg.Rows[nindex]["PkgName"].ToString();
            pkgStartDateDateTimePicker.Value = Convert.ToDateTime(dtpkg.Rows[nindex]["PkgStartDate"]);
            pkgEndDateDateTimePicker.Value = Convert.ToDateTime(dtpkg.Rows[nindex]["PkgEndDate"]);
            pkgDescTextBox.Text= dtpkg.Rows[nindex]["PkgDesc"].ToString();
            pkgBasePriceTextBox.Text= dtpkg.Rows[nindex]["PkgBasePrice"].ToString();
            pkgAgencyCommissionTextBox.Text= dtpkg.Rows[nindex]["PkgAgencyCommission"].ToString();

            if (packageIdTextBox.Text != "")
            {
                Package pkg = new Package();
                pkg.nPkgId = Convert.ToInt32(packageIdTextBox.Text);
                dgvPkgProd.Columns.Clear();
                dgvPkgProd.DataSource = Pkg_Product_SuppliersDB.GetAllPkgProdSupData(pkg.nPkgId);
                //dgvPkgSup.DataSource = Pkg_Product_SuppliersDB.GetAllPkgSupData(pkg.nPkgId);
            }
        }

        private void PackagesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

            refreshitems();
        }

        private void PackagesBindingNavigator_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            
        }

        private void PkgBasePriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            else if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else
            {
                lblPkgBasePriceErr.Text = "Only numeric value allowed!";
            }
        }

        private void PkgAgencyCommissionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            else if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else
            {
                lblPkgAgentComErr.Text= "Only numeric value allowed!";
            }
        }

        //private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        //{
        //    dgvPkgProd.DataSource = null;
        //    dgvPkgProd.ColumnCount = 1;
        //    dgvPkgProd.Columns[0].Name = "ProdName";
        //}

        private void BtnDeductProdfromPkg_Click(object sender, EventArgs e)
        {
            
            //if pkg with prod_sup
            //update pkg_prod_sup delete record
            if (dgvPkgProd.Rows.Count > 0)
            {
                if (packageIdTextBox.Text == "" || packageIdTextBox.Text == "-1")
                {
                    //if new package
                    //remove row
                    if (dgvPkgProd.SelectedRows.Count > 0)
                    {
                        for (int i = 0; i < dgvPkgProd.SelectedRows.Count; i++)
                        {
                            dgvPkgProd.Rows.RemoveAt(dgvPkgProd.SelectedRows[i].Index);
                            dgvPkgProd.Refresh();
                        }
                    }

                }
                else if (packageIdTextBox.Text != "" && packageIdTextBox.Text != "-1")
                {
                    //if pkg with prod_sup
                    //update pkg_prod_sup delete record
                    int pkgId = Convert.ToInt32(packageIdTextBox.Text);
                    DataTable dt = Pkg_Product_SuppliersDB.GetAllPsDatabyPkgId(pkgId);
                    if (dgvPkgProd.SelectedRows.Count > 0)
                    {

                        for (int i = 0; i < dgvPkgProd.SelectedRows.Count; i++)
                        {
                            //delete pkg_prod_sup record according to datagridview prodname and supname
                            int prodId = ProductDB.GetProductsbyName(dgvPkgProd.SelectedRows[i].Cells[0].Value.ToString()).nProdId;
                            int supId = SupplierDB.GetSuppliersbyName(dgvPkgProd.SelectedRows[i].Cells[1].Value.ToString()).nSupId;

                            DataTable dtps = Prod_SuppliersDB.GetProd_SupbyPsId(prodId, supId);
                            for (int m = 0; m < dtps.Rows.Count; m++)
                            {
                                int prodsupId = Convert.ToInt32(dtps.Rows[m]["ProductSupplierId"]);
                                for (int j = 0; j < dt.Rows.Count; j++)
                                {
                                    int ppspsId = Convert.ToInt32(dt.Rows[j]["ProductSupplierId"]);
                                    if (prodsupId == ppspsId)
                                    {
                                        Pkg_Product_Suppliers pps = new Pkg_Product_Suppliers();
                                        pps.pkgId = pkgId;
                                        pps.prodSupId = prodsupId;
                                        Pkg_Product_SuppliersDB.DeletePPSbypps(pps);
                                    }
                                }
                            }

                        }
                        refreshitems();
                    }
                    
                }
            }
        }

        private bool validateprodSup()
        {
            if(cbProducts.Text=="")
            {
                lblProdsErr.Text = "Products is required!";
                return false;
            }
            if(cbSups.Text=="")
            {
                lblSupsErr.Text = "Supliers is required!";
                return false;
            }
            return true;
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
           // PackagesBindingNavigator.PositionItem.Text = Convert.ToString( Convert.ToInt32( PackagesBindingNavigator.PositionItem.Text) + 1);
            refreshitems();
        }

        private void PackagesBindingNavigator_RefreshItems_1(object sender, EventArgs e)
        {
            
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            refreshitems();
        }

        private void BindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            BindingSource pkgbindsource = new BindingSource();
            pkgbindsource.DataSource = PackageDB.GetAllPkg();
            PackagesBindingNavigator.BindingSource = pkgbindsource;

            packageIdTextBox.Text = "-1";
            pkgNameTextBox.Text = "";
            pkgStartDateDateTimePicker.Value = DateTime.Now;
            pkgEndDateDateTimePicker.Value = DateTime.Now;
            pkgDescTextBox.Text = "";
            pkgBasePriceTextBox.Text = "";
            pkgAgencyCommissionTextBox.Text = "";

            dgvPkgProd.DataSource = null;
            dgvPkgProd.ColumnCount = 2;
            dgvPkgProd.Columns[0].HeaderText = "ProdName";
            dgvPkgProd.Columns[1].HeaderText = "SupName";
        }

        private void CbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshsups(); 
        }

        private void BtnAddProdSup_Click(object sender, EventArgs e)
        {
            if (validateprodSup())
            {
                //if current pkg have prod sup already change current package prod supplier
                //update pkg_prod_supplier
                //if current no prod sup
                //add new recordd into pkg_prod_supplier
                //if add to new package
                //reemove binding souce of datagridview(done by package add button already) and just add row
                int pkgId = Convert.ToInt32(packageIdTextBox.Text);
                if(pkgId==-1)//new package
                {
                    //create new package
                    //if no prod_supplier info then insert only package info
                    //if have prod_supplier info then insert package and package_product_supplier info
                    if (dgvPkgProd.Rows.Count > 0)
                    {
                        //have prod_supplier info then insert package and package_product_supplier info
                        List<Prod_Suppliers> prodlist = new List<Prod_Suppliers>();
                        for (int j = 0; j < dgvPkgProd.Rows.Count; j++)
                        {
                            Prod_Suppliers prodsup = new Prod_Suppliers();
                            prodsup.strProdName = dgvPkgProd.Rows[j].Cells[0].Value.ToString();
                            prodsup.strSupName = dgvPkgProd.Rows[j].Cells[1].Value.ToString();
                            prodlist.Add(prodsup);
                        }

                        for (int j = 0; j < prodlist.Count; j++)
                        {

                            if ((cbProducts.Text == prodlist[j].strProdName) && (cbSups.Text == prodlist[j].strSupName))
                            {
                                prodlist.RemoveAt(j);
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        if (prodlist.Count > 0)
                        {
                            for (int i = 0; i < prodlist.Count; i++)
                            {
                                DataGridViewRow newrow = (DataGridViewRow)dgvPkgProd.Rows[0].Clone(); ;
                                newrow.Cells[0].Value = cbProducts.Text;
                                newrow.Cells[1].Value = cbSups.Text;
                                dgvPkgProd.Rows.Add(newrow);
                            }
                        }
                    }
                    else
                    {
                        //No prod_supplier info, only insert package information into package table
                        DataGridViewRow newrow = new DataGridViewRow();
                        //(DataGridViewRow)dgvPkgProd.Rows;

                        newrow.Cells[0].Value = cbProducts.Text;
                        newrow.Cells[1].Value = cbSups.Text;
                        dgvPkgProd.Rows.Add(newrow);
                    }
                }
                else if(dgvPkgProd.Rows.Count > 0)
                {
                    //if combobox content already in datagridview 
                    //do nothing
                    //if not in datagridview
                    //update pkg_prod_sup insert record
                    List<Prod_Suppliers> prodlist = new List<Prod_Suppliers>();
                    bool bexist = false;
                    //take current data in table into list
                    for (int j = 0; j < dgvPkgProd.Rows.Count; j++)
                    {
                        Prod_Suppliers prodsup = new Prod_Suppliers();
                        prodsup.strProdName = dgvPkgProd.Rows[j].Cells[0].Value.ToString();
                        prodsup.strSupName = dgvPkgProd.Rows[j].Cells[1].Value.ToString();
                        prodlist.Add(prodsup);
                    }

                    for (int j = 0; j < prodlist.Count; j++)
                    {

                        if ((cbProducts.Text == prodlist[j].strProdName) && (cbSups.Text == prodlist[j].strSupName))
                        {
                            //if the product and supplier already in table then remove from the list
                            prodlist.RemoveAt(j);
                            CustMesg custMesg = new CustMesg();
                            custMesg.Showmsg("Product_Supplier Info already in table!");
                            custMesg.Show();
                            //lblAddDelMsg.Text = "Product_Supplier Info already in table!";
                            bexist = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }
                    //check data in prod_supplier table? if exist then just show info in gridview, else insert into prod_supplier table
                    //update data in package and pkg_prod_supplier
                    if(!bexist)
                        UpdateProdSupTopps(pkgId);
                }
                else
                {
                    //package no prod_supplier yet
                    InsertProdSupTopps(pkgId);
                }
                
            }
        }

        private void InsertProdSupTopps(int pkgId)
        {
            Prod_Suppliers prodsup = new Prod_Suppliers();
            Products prod = ProductDB.GetProductsbyName(cbProducts.Text);
            prodsup.nProdId = prod.nProdId;//cbProducts.SelectedValue);
            Suppliers sup = SupplierDB.GetSuppliersbyName(cbSups.Text);
            prodsup.nSupId = sup.nSupId;// Convert.ToInt32(cbSups.SelectedValue);
            DataTable dt = Prod_SuppliersDB.GetProd_SupbyPsId(prodsup.nProdId, prodsup.nSupId);
            int prodsupid =Convert.ToInt32( dt.Rows[0]["ProductSupplierId"]);
            Pkg_Product_Suppliers pps = new Pkg_Product_Suppliers();
            pps.prodSupId = prodsupid;
            pps.pkgId = pkgId;
            Pkg_Product_SuppliersDB.AddPPSData(pps);

            refreshitems();
        }

        private void UpdateProdSupTopps(int pkgId)
        {
            Prod_Suppliers prodsup = new Prod_Suppliers();
            Products prod = ProductDB.GetProductsbyName(cbProducts.Text);
            prodsup.nProdId = prod.nProdId;//cbProducts.SelectedValue);
            Suppliers sup = SupplierDB.GetSuppliersbyName(cbSups.Text);
            prodsup.nSupId = sup.nSupId;// Convert.ToInt32(cbSups.SelectedValue);
            DataTable dt = Prod_SuppliersDB.GetProd_SupbyPsId(prodsup.nProdId, prodsup.nSupId);
            int prodsupid = 0;
            if (dt.Rows.Count>0)
            {
                prodsupid = Convert.ToInt32(dt.Rows[0]["ProductSupplierId"]);
            }

            if (prodsupid > 0)
            {
                Pkg_Product_Suppliers pps = new Pkg_Product_Suppliers();
                pps.prodSupId = prodsupid;
                pps.pkgId = pkgId;
                Pkg_Product_SuppliersDB.AddPPSData(pps);

                refreshitems();
            }
            else
            {
                CustMesg custMesg = new CustMesg();
                custMesg.Showmsg("There is no supplier information in database! \n Please select other products!");
                custMesg.Show();
            }
        }
        private void ToolStripBtnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                int pkgId = 0;
                Package pkg = new Package();
                pkg.PkgName = pkgNameTextBox.Text;
                pkg.pkgStDate = pkgStartDateDateTimePicker.Value;
                pkg.pkgEndDate = pkgEndDateDateTimePicker.Value;
                pkg.pkgDesc = pkgDescTextBox.Text;
                pkg.pkgBasePrice = Convert.ToDouble(pkgBasePriceTextBox.Text);
                pkg.pkgAgentCom = Convert.ToDouble(pkgAgencyCommissionTextBox.Text);
                if(packageIdTextBox.Text=="-1")
                {
                    pkgId = PackageDB.AddPackage(pkg);
                    if (pkgId != 0)
                    {
                        if (dgvPkgProd.Rows.Count > 0)
                        {
                            for (int i = 0; i < dgvPkgProd.Rows.Count ; i++)
                            {
                                Prod_Suppliers prodsup = new Prod_Suppliers();
                                Products prod = ProductDB.GetProductsbyName(dgvPkgProd.Rows[i].Cells[0].Value.ToString());
                                prodsup.nProdId = prod.nProdId;//cbProducts.SelectedValue);
                                Suppliers sup = SupplierDB.GetSuppliersbyName(dgvPkgProd.Rows[i].Cells[1].Value.ToString());
                                prodsup.nSupId = sup.nSupId;// Convert.ToInt32(cbSups.SelectedValue);
                                DataTable dt = Prod_SuppliersDB.GetProd_SupbyPsId(prodsup.nProdId, prodsup.nSupId);
                                int prodsupid = Convert.ToInt32(dt.Rows[0]["ProductSupplierId"]);
                                //int prodsupid = Prod_SuppliersDB.AddRecord(prodsup);
                                Pkg_Product_Suppliers pps = new Pkg_Product_Suppliers();
                                pps.prodSupId = prodsupid;
                                pps.pkgId = pkgId;
                                Pkg_Product_SuppliersDB.AddPPSData(pps);
                            }
                        }
                    }
                }
                else
                { 
                    //update package
                    pkgId = Convert.ToInt32(packageIdTextBox.Text);
                   
                    if (pkgId != 0)
                    {
                        Package oldpkg = new Package();
                        oldpkg.nPkgId = pkgId;
                        PackageDB.UpdatePkg(oldpkg, pkg);
                        DataTable dtprodsup = Pkg_Product_SuppliersDB.GetAllPkgProdSupData(pkgId);

                        if (dgvPkgProd.Rows.Count > 0)
                        {
                            for (int i = 0; i < dgvPkgProd.Rows.Count ; i++)
                            {
                                string strprodname = dgvPkgProd.Rows[i].Cells[0].Value.ToString();
                                string strsupName = dgvPkgProd.Rows[i].Cells[1].Value.ToString();
                                for(int j=0;j<dtprodsup.Rows.Count;j++)
                                {
                                    if(strprodname!=dtprodsup.Rows[j]["ProdName"].ToString() && strsupName!= dtprodsup.Rows[j]["SupName"].ToString())
                                    {
                                        Prod_Suppliers prodsup = new Prod_Suppliers();
                                        Products prod = ProductDB.GetProductsbyName(dgvPkgProd.Rows[i].Cells[0].Value.ToString());
                                        prodsup.nProdId = prod.nProdId;//cbProducts.SelectedValue);
                                        Suppliers sup = SupplierDB.GetSuppliersbyName(dgvPkgProd.Rows[i].Cells[1].Value.ToString());
                                        prodsup.nSupId = sup.nSupId;// Convert.ToInt32(cbSups.SelectedValue);
                                        DataTable dt= Prod_SuppliersDB.GetProd_SupbyPsId(prodsup.nProdId, prodsup.nSupId);
                                        Prod_Suppliers newprodsup = new Prod_Suppliers ();
                                        newprodsup.nProdSupId = Convert.ToInt32(dt.Rows[0]["ProductSupplierId"]);
                                        int prodsupid = newprodsup.nProdSupId;
                                        Pkg_Product_Suppliers oldpps = new Pkg_Product_Suppliers();
                                        Pkg_Product_Suppliers pps = new Pkg_Product_Suppliers();
                                        pps.prodSupId = prodsupid;
                                        oldpps.pkgId = pkgId;
                                        Pkg_Product_SuppliersDB.UpdatePkgData(oldpps, pps);
                                    }
                                }
                                
                            }
                        }
                    }
                }
                BindingSource pkgbindsource = new BindingSource();
                pkgbindsource.DataSource = PackageDB.GetAllPkg();
                PackagesBindingNavigator.BindingSource = pkgbindsource;

                refreshitems(); 
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(packageIdTextBox.Text!="" && packageIdTextBox.Text != "-1")
            {
                int pkgId = Convert.ToInt32(packageIdTextBox.Text);
                //pkgId = Convert.ToInt32(packageIdTextBox.Text);
                if (Pkg_Product_SuppliersDB.CheckDatabyPkgID(pkgId))
                {
                    Package oldpkg = new Package();
                    oldpkg.nPkgId = pkgId;
                   
                    if (pkgId != 0)
                    {
                        Pkg_Product_Suppliers pps = new Pkg_Product_Suppliers();
                        pps.pkgId = pkgId;
                        Pkg_Product_SuppliersDB.DeletePPSbyPkgId(pps);
                        if(!BookingDB.CheckPackageIdInuse(pkgId))
                            PackageDB.DeletePackage(oldpkg);
                        else
                        {
                            CustMesg cust = new CustMesg();
                            cust.Showmsg("Package is in use in Bookings table!");
                            cust.Show();
                        }
                    }
                    BindingSource pkgbindsource = new BindingSource();
                    pkgbindsource.DataSource = PackageDB.GetAllPkg();
                    PackagesBindingNavigator.BindingSource = pkgbindsource;
                    refreshitems();
                    
                }
                else if (PackageDB.CheckPackIdExist(pkgId))
                {
                    Package oldpkg = new Package();
                    oldpkg.nPkgId = pkgId;
                    if (!BookingDB.CheckPackageIdInuse(pkgId))
                        PackageDB.DeletePackage(oldpkg);
                    else
                    {
                        CustMesg cust = new CustMesg();
                        cust.Showmsg("Package is in use in Bookings table!");
                        cust.Show();
                    }
                    BindingSource pkgbindsource = new BindingSource();
                    pkgbindsource.DataSource = PackageDB.GetAllPkg();
                    PackagesBindingNavigator.BindingSource = pkgbindsource;
                    refreshitems();
                    
                }
                else
                {
                    //Pkg_Product_Suppliers pps = new Pkg_Product_Suppliers();
                    //pps.pkgId = pkgId;
                    //Pkg_Product_SuppliersDB.DeletePPSbyPkgId(pps);

                    //Package oldpkg = new Package();
                    //oldpkg.nPkgId = pkgId;
                    //PackageDB.DeletePackage(oldpkg);
                    //if (pkgId != 0)
                    //{
                    //    Pkg_Product_Suppliers pkgps = new Pkg_Product_Suppliers();
                    //    pps.pkgId = pkgId;
                    //    Pkg_Product_SuppliersDB.DeletePPSbyPkgId(pkgps);

                    //}
                    BindingSource pkgbindsource = new BindingSource();
                    pkgbindsource.DataSource = PackageDB.GetAllPkg();
                    PackagesBindingNavigator.BindingSource = pkgbindsource;
                    refreshitems();
                    CustMesg cust = new CustMesg();
                    cust.Showmsg("Not a valid record!");
                    cust.Show();
                    
                   // MessageBox.Show("The Package is using in Package_Product_Supplier Table, Please delete record in Package_Product_Supplier Table First!");
                }
            }
            else
            {
                BindingSource pkgbindsource = new BindingSource();
                pkgbindsource.DataSource = PackageDB.GetAllPkg();
                PackagesBindingNavigator.BindingSource = pkgbindsource;
                refreshitems();
                CustMesg cust = new CustMesg();
                cust.Showmsg("Not a valid record!");
                cust.Show();
            }
            
        }

        private void PkgNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation();
        }

        private void PkgStartDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Validation();
        }

        private void PkgEndDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void PkgDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation();
        }

        private void PkgBasePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void PkgAgencyCommissionTextBox_TextChanged(object sender, EventArgs e)
        {
            Validation();
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

        private void PkgStartDateDateTimePicker_Leave(object sender, EventArgs e)
        {
            Validation();
        }
    }
}
