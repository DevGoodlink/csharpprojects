using System;

namespace WebApplication1.Models
{
    public class FormationPro
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public DateTime DateFormation { get; set; }
        public string Description { get; set; }
        public string Etablissement { get; set; }
    }
}