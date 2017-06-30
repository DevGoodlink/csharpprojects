using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace exempleMysql
{
    public class WorldEntities : DbContext
    {
        public WorldEntities() : base("name=World")
        {

        }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CountryLanguage> CountriesLanguages { get; set; }
    }
}
