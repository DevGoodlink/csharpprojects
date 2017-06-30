using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetHeritageDB
{
    class Program
    {
        static void Main(string[] args)
        {
          
            using ( tptEntities myctx = new tptEntities())
            {
                try
                {
                    PERMANENT p1 = new PERMANENT();
                    p1.ID = 10;
                    p1.Nom = "Bouanani";
                    p1.Prenom = "Ahmed";
                    p1.salaireMensuel = 12000;
                    myctx.PROFs.Add(p1);
                    VACCATAIRE v1 = new VACCATAIRE();
                    v1.ID = 11;
                    v1.Nom = "Ali";
                    v1.Prenom = "Mohamed";
                    v1.nbreHeure = 40;
                    v1.TauxHoraire = 400;
                    myctx.PROFs.Add(v1);
                    myctx.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                Console.Read();

            }
        }
    }
}
