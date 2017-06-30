using System;

namespace WebApplication1.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DatePublication { get; set; }
        public string Journal { get; set; }
        public string Lien { get; set; }

    }
}