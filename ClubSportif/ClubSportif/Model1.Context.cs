﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClubSportif
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class clubSportEntities1 : DbContext
    {
        public clubSportEntities1()
            : base("name=clubSportEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<assurance> assurances { get; set; }
        public virtual DbSet<membre> membres { get; set; }
        public virtual DbSet<athlete> athletes { get; set; }
        public virtual DbSet<entraineur> entraineurs { get; set; }

    }
}
