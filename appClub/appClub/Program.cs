using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClub
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Contexte ctx = new Contexte())
            {
                //Athlete at1 = new Athlete();
                //at1.Id = 3;
                //at1.Nom = "Guerrouj"; at1.Prenom = "Hicham"; at1.Telephone = "111111"; at1.DateInscription = new DateTime(2015, 1, 1);
                //Assurance ass = new Assurance() { AssuranceId = 1, DateDebut = new DateTime(2015, 1, 1), DateFin = new DateTime(2016, 1, 1), Athlete = at1 };

                //ctx.Assurances.Add(ass);
                //ctx.Athletes.Add(at1);
                /*
                Entraineur ent = new Entraineur() { Id = 1, Nom = "Zaki", Prenom = "Mohamed", Adresse = "casa", Discipline = "Foot", Telephone = "111111" };
                Entraineur ent0 = new Entraineur() { Id = 2, Nom = "Fakhir", Prenom = "Hassan", Adresse = "casa", Discipline = "Foot", Telephone = "111111" };
                Entraineur ent1 = new Entraineur() { Id = 3, Nom = "Meliani", Prenom = "Ali", Adresse = "casa", Discipline = "Foot", Telephone = "111111" };
               
                ctx.Entraineurs.Add(ent); ctx.Entraineurs.Add(ent0); ctx.Entraineurs.Add(ent1);


                ctx.SaveChanges(); */
                Console.WriteLine("Liste des entraineurs : ");
                List<Entraineur> lstE = (from ent in ctx.Entraineurs
                                         select ent).ToList();

                if(lstE != null)
                {
                    foreach (Entraineur item in lstE)
                    {
                        Console.WriteLine(item.Id + " " + item.Nom + " " + item.Prenom);
                    }
                }
                List<Athlete> lstAt = (from a in ctx.Athletes
                                       select a).ToList();
                Console.WriteLine("Liste des athlètes :");
                if (lstAt != null)
                {
                    foreach (Athlete item in lstAt)
                    {
                        Console.WriteLine(""+item.Id+" "+ item.Nom+" "+ item.Prenom+" "+ item.Telephone);
                    }
                }
                //Liste des athlètes ayant des assurance expirées 
                List<Assurance> lstAss = (from assu in ctx.Assurances where assu.DateFin < new DateTime(2017,01,18)
                                          select assu).ToList();
                Console.WriteLine("Liste des athlètes dans l'assurance est expirée :");
                foreach (Assurance item in lstAss)
                {
                    Console.WriteLine(item.Athlete.Id + " " + item.Athlete.Nom);
                }


                Console.WriteLine("111111111111111111111111111111");
                
            }
            Console.Read();
        }
    }
}
