using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace appClub
{
    class Contexte : DbContext
    {
        public Contexte():base("db_club")
        {

        }
        public DbSet<Entraineur> Entraineurs { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Assurance> Assurances { get; set; }

    }
}
