using System;

namespace WebApplication1.Models
{
    public class Mission
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Objectif { get; set; }
        public string Description { get; set; }
        public string Etablissement { get; set; }

    }
}