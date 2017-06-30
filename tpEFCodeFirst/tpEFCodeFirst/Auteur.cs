using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpEFCodeFirst
{
    public class Auteur
    {
        public int ID { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public virtual ICollection<Ouvrage> ouvrages { get; set; }
    }
}
