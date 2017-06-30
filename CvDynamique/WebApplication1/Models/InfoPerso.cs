using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class InfoPerso
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public DateTime Dn { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        public string Biographie { get; set; }
        public string LienPhoto { get; set; }
    }
}