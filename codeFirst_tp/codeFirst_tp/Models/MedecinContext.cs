using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst_tp.Models
{
    class MedecinContext : DbContext
    {
        public DbSet<Medecin>  Medecins { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public MedecinContext():base("name=clinic")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Console.Write("Database generated");
        }
    }
}
