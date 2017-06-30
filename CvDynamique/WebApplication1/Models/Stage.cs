using System;

namespace WebApplication1.Models
{
    public class Stage
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Etablissement { get; set; }
        public string Description { get; set; }
    }
}