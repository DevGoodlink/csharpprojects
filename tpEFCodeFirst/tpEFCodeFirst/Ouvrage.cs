using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpEFCodeFirst
{
    public class Ouvrage
    {
        public int ID { get; set; }
        public string Titre { get; set; }

        public virtual Auteur auteur { get; set; }

    }
}
