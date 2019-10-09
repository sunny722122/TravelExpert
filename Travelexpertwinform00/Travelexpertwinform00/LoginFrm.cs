using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Travelexpertwinform00
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private bool validation()
        {
            if(txtPwd.Text=="")
            {
                lblPwdErr.Text = "Password is required!";
                return false;
            }
            else
            {
                lblPwdErr.Text = "";
            }

            if(txtUsrID.Text=="")
            {
                lblUserIdErr.Text = "UserID is required!";
                return false;
            }
            else
            {
                lblUserIdErr.Text = "";
            }
            return true;
        }

        

    public static byte[] GetHash(string inputString)
    {
        HashAlgorithm algorithm = SHA256.Create();
        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
    }

    public static string GetHashString(string inputString)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in GetHash(inputString))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }
    private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                AgentLogin agent = new AgentLogin ();
                agent.nAgentId = Convert.ToInt32(txtUsrID.Text);
                agent.strPassword = GetHashString(txtPwd.Text);
                if(AgentLogInDB.CheckIDexist(agent.nAgentId))
                {
                    if(AgentLogInDB.CheckPwdMatch(agent))
                    {
                        MainFrm mainfrm = new MainFrm();
                        if(!FrmValid.checkformopen(mainfrm.Text))
                        {
                            FrmValid.AgentId = agent.nAgentId;
                            //this.Close();
                            mainfrm.Show();
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Wrong!");
                    }
                }
                else
                {
                    MessageBox.Show("User is not exist!");
                }
            }
            
        }

        private void TxtUsrID_TextChanged(object sender, EventArgs e)
        {
            validation();
        }

        private void TxtPwd_TextChanged(object sender, EventArgs e)
        {
            validation();
        }

        private void BtnAccNew_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                AgentLogin agent = new AgentLogin();
                agent.nAgentId = Convert.ToInt32(txtUsrID.Text);
                agent.strPassword = GetHashString(txtPwd.Text);
                if (AgentLogInDB.CheckIDexist(agent.nAgentId))
                {
                    AgentLogInDB.UpdateAgentLogin(agent, agent);
                    MessageBox.Show("Password updated!");
                }
                else
                {
                    AgentLogInDB.AddAgentLogIn(agent);
                    MessageBox.Show("Account created!");
                }
            }
            
        }

        private void LoginFrm_Activated(object sender, EventArgs e)
        {
            //FrmValid.closeallotherform(this.Text);
        }
    }
}
