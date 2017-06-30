using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tpDB.Models
{
    public class BddContext : DbContext
    {
        public BddContext() : base("name=Sondage")
        {
            
        }
        public DbSet<Sondage> Sondages { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}