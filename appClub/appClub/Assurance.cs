using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClub
{
    class Assurance
    {
        public Assurance()
        {

        }
        [Key]
        public int AssuranceId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public Athlete Athlete { get; set; }
    }
}
