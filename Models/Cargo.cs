using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLine.Models
{
    public class Cargo
    {
        public int ID { get; set; }
        public int CargoWeight { get; set; }
        public string CargoMaterial { get; set; }
        public int WarehouseNo { get; set; }
        public string CargoTag { get; set; }
    }
}
