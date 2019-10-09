using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelexpertwinform00
{
    class Package
    {
        public Package()
        {

        }
        public int nPkgId { get; set; }
        public string PkgName { get; set; }
        public DateTime pkgStDate { get; set; }
        public DateTime pkgEndDate { get; set; }
        public string pkgDesc { get; set; }
        public double pkgBasePrice { get; set; }
        public double pkgAgentCom { get; set; }
    }
}
