using System;

namespace WebApplication1.Models
{
    public class Projet
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Collaborateurs { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Lien { get; set; }

    }
}