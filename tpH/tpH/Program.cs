using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpH
{
    class Program
    {
        static void Main(string[] args)
        {
            using (tptEntities ctx = new tptEntities())
            {

                VACATAIRE v1 = new VACATAIRE() { ID = 10, email = "jjj", Nom = "jjjjooo", nbreHeure = 50, Prenom = "aaaaa", tauxHoraire = 500 };
                PERMANENT p1 = new PERMANENT() { ID = 11, email = "aaaaaa", Nom = "bbbb", Prenom = "ccccc", salaireMensuel = 12000 };
                ctx.PROFESSEURs.Add(p1);
                ctx.PROFESSEURs.Add(v1);
                ctx.SaveChanges();

            }
        }
    }
}
