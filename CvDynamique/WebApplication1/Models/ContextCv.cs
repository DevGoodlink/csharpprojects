using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ContextCv : DbContext
    {
        public ContextCv() : base(@"Server=(localdb)\v11.0;Integrated Security=true;
                        AttachDbFileName = C:\Users\toshiba\Documents\Visual Studio 2017\Projects\WebApplication1\
                        WebApplication1\App_Data\db_cv.mdf;") { }
        public DbSet<InfoPerso> InfoPersos { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<FormationPro> FormationsPro { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Cours> CoursS { get; set; }
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<ExperiencePro> ExperiencesPro { get; set; }
        public DbSet<Langue> Langues { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Projet> Projets { get; set; }
        public DbSet<Stage> Stages { get; set; }



    }
}