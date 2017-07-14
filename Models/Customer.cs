using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLine.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public int CustID { get; set; }
        public string CustName { get; set; }
        public int CustAge  { get; set; }
        public string CustJob { get; set; }
    }
}
