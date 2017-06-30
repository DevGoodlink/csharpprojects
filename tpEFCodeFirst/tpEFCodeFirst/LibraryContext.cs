using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpEFCodeFirst
{
    
        public class LibraryContext : DbContext
        {
            public LibraryContext() : base("name=CodeFirstSampleEntities")
            {

            }

            public virtual DbSet<Auteur> auteurs { get; set; }
            public virtual DbSet<Ouvrage> ouvrages { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                Console.WriteLine("DbContext libraryContext créé avec succés");
            }
    }

   
}
