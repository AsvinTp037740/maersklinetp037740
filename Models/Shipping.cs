using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLine.Models
{
    public class Shipping
    {
        public int ID { get; set; }
        public int ShipID { get; set; }
        public string Destination { get; set; }
        public string CargoTag { get; set; }
        public string ShippingDate { get; set; }
        public string ShippingStatus { get; set; }
    }
}
