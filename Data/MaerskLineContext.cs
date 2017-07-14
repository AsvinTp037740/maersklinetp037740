using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaerskLine.Models;

namespace MaerskLine.Models
{
    public class MaerskLineContext : DbContext
    {
        public MaerskLineContext (DbContextOptions<MaerskLineContext> options)
            : base(options)
        {
        }

        public DbSet<MaerskLine.Models.Customer> Customer { get; set; }

        public DbSet<MaerskLine.Models.Warehouse> Warehouse { get; set; }

        public DbSet<MaerskLine.Models.Cargo> Cargo { get; set; }

        public DbSet<MaerskLine.Models.Agent> Agent { get; set; }

        public DbSet<MaerskLine.Models.Shipping> Shipping { get; set; }

        public DbSet<MaerskLine.Models.Cargocargo> Cargocargo { get; set; }
    }
}
