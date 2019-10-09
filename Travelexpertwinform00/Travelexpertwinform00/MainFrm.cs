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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void BtnPackage_Click(object sender, EventArgs e)
        {
            PackageFrm pkgfrm = new PackageFrm();

            string strtitle = "Packages";
            if(!FrmValid. checkformopen(strtitle))
            {
                pkgfrm.Show();
                this.Close();
            }
            
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //LoginFrm loginfrm = new LoginFrm();
            //if(FrmValid.checkformopen(loginfrm.Text))
            //{
            //    FrmValid.closeopenedform(loginfrm.Text);
            //}
            lblGreeting.Text = "Agent ID " + FrmValid.AgentId.ToString() + " Logged in!";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginFrm loginfrm = new LoginFrm();
            if(! FrmValid.checkformopen(loginfrm.Text))
            {
                FrmValid.AgentId = 0;
                loginfrm.Show();
            }
            else
            {
                FrmValid.Activateform(loginfrm.Text);
                this.Close();
            }
        }

        private void BtnProdSup_Click(object sender, EventArgs e)
        {
            ProdSupFrm prodsupfrm = new ProdSupFrm();

            string strtitle = "Packages";
            if (!FrmValid.checkformopen(strtitle))
            {
                prodsupfrm.Show();
                this.Close();
            }
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            ProductFrm prodfrm = new ProductFrm();

            
            if (!FrmValid.checkformopen(prodfrm.Text))
            {
                prodfrm.Show();
                this.Close();
            }
        }

        private void BtnSup_Click(object sender, EventArgs e)
        {
            SupplierFrm supfrm = new SupplierFrm();
            if(!FrmValid.checkformopen(supfrm.Text))
            {
                supfrm.Show();
                this.Close();
            }
        }
    }
}