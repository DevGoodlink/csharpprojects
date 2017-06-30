using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Formation
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public DateTime DateObtention { get; set; }
        public string Etablissement { get; set; }
        public string Description { get; set; }
        public string Mention { get; set; }
    }
}