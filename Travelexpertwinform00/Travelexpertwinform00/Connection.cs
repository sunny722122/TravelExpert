using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Travelexpertwinform00
{
    class Connection
    {
        public static string constr { get; set; }
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
    }
}
