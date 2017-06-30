using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst_tp.Models
{
    class DbCreate
    {
        public static void main()
        {
            using (MedecinContext ctxMedecin = new MedecinContext())
            {
                Medecin m = new Medecin() { Nom = "Sbai", Prenom="Mohamed"};
                Operation o = new Operation() {HeureDebut=6,HeureFin=8,medecin=m };
                ctxMedecin.Operations.Add(o);
                ctxMedecin.Medecins.Add(m);
                ctxMedecin.SaveChanges();

            }
        }
        
    }
}
