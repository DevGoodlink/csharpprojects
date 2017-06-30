using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CntxWithMySql
{
    [Table("countryLanguage")]
    public class CountryLanguage
    {
        [Key]
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public string IsOfficial { get; set; }
        public double Percentage { get; set; }
        public virtual Country country { get; set; }
    }
}
