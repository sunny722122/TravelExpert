using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travelexpertwinform00
{
    class FrmValid
    {
        public FrmValid()
        {

        }

        public static int AgentId { get; set; }

        public static bool checkformopen(string strfrmname)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == strfrmname)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool closeopenedform(string strfrmname)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == strfrmname)
                {
                    frm.Close();
                    return true;
                }
            }
            return false;
        }

        public static void closeallotherform(string strfrmname)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name != strfrmname)
                {
                    frm.Close();
                    //return true;
                }
            }
           // return false;
        }

        public static void Activateform(string strfrmname)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == strfrmname)
                {
                    frm.Activate();
                    frm.Visible = true;
                    //return true;
                }
                
            }
           // return false;
        }
    }
}
