using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpDB.Models
{
    public interface IDal:IDisposable
    {
        void CreerRestaurant(string nom, string telephone);
        void ModifierRestaurant(int id,string nom, string telephone);
        void CreerUtilisateur(string Nom, string Prenom, string Telephone);
        void CreerVote(Utilisateur u, Restaurant r);
        void CreerSondage(List<Vote> votes, DateTime d);
        List<Restaurant> ObtientTousLesRestaurants();
    }
}
