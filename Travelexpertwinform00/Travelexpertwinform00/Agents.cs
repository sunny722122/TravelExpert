using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelexpertwinform00
{
    class Agents
    {
        public Agents()
        {

        }
        //Agent ID
        public int nAgentId { get; set; }
        public string AgentFirstName { get; set; }
        public string AgentMiddleInitial { get; set; }
        public string AgtLastName { get; set; }
        public string AgtBusPhone { get; set; }
        public string AgtEmail { get; set; }
        public string AgtPosition { get; set; }
        public int AgencyId { get; set; }
    }
}
