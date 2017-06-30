using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CntxWithMySql
{
    public class WorldEntities : DbContext
    {
        public WorldEntities() : base("name=world")
        {

        }
        
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CountryLanguage> CountriesLanguages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Console.WriteLine("Création du contexte");
            base.OnModelCreating(modelBuilder);
        }
    }
}
