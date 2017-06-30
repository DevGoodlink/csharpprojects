using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CntxWithMySql
{
    [Table("country")]
    public class Country
    {
        public Country()
        {
            this.countrylanguages = new HashSet<CountryLanguage>();
            this.cities = new HashSet<City>();
        }
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public double SurfaceArea { get; set; }
        public Nullable<short> IndepYear { get; set; }
        public int Population { get; set; }
        public Nullable<double> LifeExpectancy { get; set; }
        public Nullable<double> GNP { get; set; }
        public Nullable<double> GNPOld { get; set; }
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public Nullable<int> Capital { get; set; }
        public string Code2 { get; set; }

        public virtual ICollection<CountryLanguage> countrylanguages { get; set; }

        public virtual ICollection<City> cities { get; set; }


    }
}
