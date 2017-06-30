﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbFirst_autoecole
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AutoEcoleEntities1 : DbContext
    {
        public AutoEcoleEntities1()
            : base("name=AutoEcoleEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ELEVE> ELEVEs { get; set; }
        public virtual DbSet<LECON> LECONs { get; set; }
        public virtual DbSet<VEHICULE> VEHICULEs { get; set; }
    
        public virtual int pEleve_INSERT(string nom, Nullable<System.DateTime> dateInscription, string prenom, string adresse, Nullable<int> creditHoraire)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var dateInscriptionParameter = dateInscription.HasValue ?
                new ObjectParameter("dateInscription", dateInscription) :
                new ObjectParameter("dateInscription", typeof(System.DateTime));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("adresse", adresse) :
                new ObjectParameter("adresse", typeof(string));
    
            var creditHoraireParameter = creditHoraire.HasValue ?
                new ObjectParameter("creditHoraire", creditHoraire) :
                new ObjectParameter("creditHoraire", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pEleve_INSERT", nomParameter, dateInscriptionParameter, prenomParameter, adresseParameter, creditHoraireParameter);
        }
    
        public virtual ObjectResult<ELEVE> AjoutEleve(string nom, Nullable<System.DateTime> dateInscription, string prenom, string adresse, Nullable<int> creditHoraire)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var dateInscriptionParameter = dateInscription.HasValue ?
                new ObjectParameter("dateInscription", dateInscription) :
                new ObjectParameter("dateInscription", typeof(System.DateTime));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("adresse", adresse) :
                new ObjectParameter("adresse", typeof(string));
    
            var creditHoraireParameter = creditHoraire.HasValue ?
                new ObjectParameter("creditHoraire", creditHoraire) :
                new ObjectParameter("creditHoraire", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ELEVE>("AjoutEleve", nomParameter, dateInscriptionParameter, prenomParameter, adresseParameter, creditHoraireParameter);
        }
    
        public virtual ObjectResult<ELEVE> AjoutEleve(string nom, Nullable<System.DateTime> dateInscription, string prenom, string adresse, Nullable<int> creditHoraire, MergeOption mergeOption)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var dateInscriptionParameter = dateInscription.HasValue ?
                new ObjectParameter("dateInscription", dateInscription) :
                new ObjectParameter("dateInscription", typeof(System.DateTime));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("adresse", adresse) :
                new ObjectParameter("adresse", typeof(string));
    
            var creditHoraireParameter = creditHoraire.HasValue ?
                new ObjectParameter("creditHoraire", creditHoraire) :
                new ObjectParameter("creditHoraire", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ELEVE>("AjoutEleve", mergeOption, nomParameter, dateInscriptionParameter, prenomParameter, adresseParameter, creditHoraireParameter);
        }
    }
}
