using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbFirst_autoecole
{
    class Program
    {
        static void Main(string[] args)
        {


            using (AutoEcoleEntities1 ctx = new AutoEcoleEntities1())
            {
                //ELEVE e = new ELEVE() { code = 50, nom = "Sahi", prenom = "Omar", adresse = "Fes", creditHoraire = 60, dateInscription = DateTime.Now };
                //try
                //{
                //    ctx.ELEVEs.Add(e);
                //    ctx.SaveChanges();
                //}
                //catch (Exception ex)
                //{

                //    Console.WriteLine(ex.Message);
                //}


                /*List<ELEVE> lstEleve = ctx.ELEVEs.ToList<ELEVE>();

                Console.WriteLine("Nbr d'élèves dans la base = " + lstEleve.Count);
                foreach (ELEVE e1 in lstEleve)
                {
                    Console.WriteLine("Nom : " + e1.nom + "\t prénom :" + e1.prenom);
                }
                Console.WriteLine("//Modification du prénom l'élève OMAR");

                ELEVE eToUpdate = ctx.ELEVEs.Find(50);
                //List<ELEVE> lstElve = query.ToList<ELEVE>();
                //ELEVE eToUpdate = lstEleve.First();
                eToUpdate.prenom = "Tarik";
                //Console.WriteLine(eToUpdate.ToString());
                /*
                 * 
                 * from ELEVE in ctx.ELEVEs
                                where ELEVE.nom == "Omar"
                                select ELEVE;
                                */
               //ctx.SaveChanges();

                //ctx.SaveChanges();
                //lstEleve = ctx.ELEVEs.ToList<ELEVE>();

               /* Console.WriteLine("Nbr d'élèves dans la base = " + lstEleve.Count);
                foreach (ELEVE e1 in lstEleve)
                {
                    Console.WriteLine("Nom : " + e1.nom + "\t prénom :" + e1.prenom);
                }*/
                /*Console.WriteLine("//Ajout de l'élève charki ");
                ctx.pEleve_INSERT("Charki",  DateTime.Now, "Mohamed", "Casablanca",90);
                ctx.SaveChanges();
                Console.WriteLine("suppresion de l'élève numéro 50");
                ELEVE eToDel = ctx.ELEVEs.Find(50);
                ctx.ELEVEs.Remove(eToDel);
                Console.WriteLine("Eléve code 50 est supprimé");
                List<ELEVE> lstEleve = ctx.ELEVEs.ToList();
                foreach (ELEVE e1 in lstEleve)
                {
                    Console.WriteLine(e1.code+"\t Nom : " + e1.nom + "\t prénom :" + e1.prenom);
                }*/
                Console.WriteLine("Les leçons de l'élève 12");
                var query = from LECON in ctx.LECONs
                            where LECON.ELEVE.nom == "Branchu"
                            select LECON;
                List<LECON> lstLessons = query.ToList();
                foreach (LECON l in lstLessons)
                {
                    Console.WriteLine("Leçon = " + l.codeEleve + ", " + l.date);
                }
            }
            
            Console.ReadKey();
          }
        
    }
}
