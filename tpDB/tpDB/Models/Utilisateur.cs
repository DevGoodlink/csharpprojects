using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpDB.Models
{
    public class Utilisateur
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
    }
}