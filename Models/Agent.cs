using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLine.Models
{
    public class Agent
    {
        public int ID { get; set; }
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string AgentCompany { get; set; }
        public string AgentRole { get; set; }
    }
}
