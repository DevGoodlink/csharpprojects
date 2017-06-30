using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testUnitaire.Models
{
    public class Dal:IDal
    {
        public Meteo ObtenirLaMeteoDuJour()
        {
            //ici le code pour accéder au service web mais peu importe on va bouchonner la méthode.
            throw new NotImplementedException();
        }
    }
}