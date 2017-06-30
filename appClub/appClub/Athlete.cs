using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClub
{
    class Athlete : Membre
    {
        public Athlete()
        {
                
        }
        public DateTime DateInscription { get; set; }
        public DbSet<Assurance> Assurances { get; set; }
    }
}
