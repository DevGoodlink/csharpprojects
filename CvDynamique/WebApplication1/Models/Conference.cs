using System;

namespace WebApplication1.Models
{
    public class Conference
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Lien { get; set; }
        public string Titre { get; set; }
        public DateTime Date { get; set; }
    }
}