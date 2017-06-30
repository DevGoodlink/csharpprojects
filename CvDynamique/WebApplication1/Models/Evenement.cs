using System;

namespace WebApplication1.Models
{
    public class Evenement
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Lien { get; set; }
    }
}