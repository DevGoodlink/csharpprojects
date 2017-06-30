using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour yasser");
            using (LibraryContext lc = new LibraryContext())
            {
                Auteur a1 = new Auteur();
                a1.ID = 1;
                a1.nom = "Tahar";
                a1.prenom = "Benjelloun";

                Ouvrage o = new Ouvrage();
                o.ID = 1;
                o.auteur = a1;
                o.Titre = "La civilisation ma mère";
                
                a1.ouvrages = new List<Ouvrage>();
                a1.ouvrages.Add(o);

                lc.ouvrages.Add(o);
                lc.auteurs.Add(a1);
                lc.SaveChanges();
            }
            Console.Read();
        }
    }
}
