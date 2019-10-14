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
    public partial class CustMesg : Form
    {
        public CustMesg()
        {
            InitializeComponent();
        }

        public void Showmsg(string msg)
        {
            lblMsg.Text = msg;
        }
    }
}
