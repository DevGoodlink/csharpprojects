using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpDB.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;
        public Dal()
        {
            bdd = new BddContext();
        }
        public void CreerRestaurant(string nom, string telephone)
        {
            Restaurant r = new Restaurant() { Nom = nom, Telephone = telephone };
            bdd.Restaurants.Add(r);
            bdd.SaveChanges();
        }

        public void CreerSondage(List<Vote> votes, DateTime d)
        {
            throw new NotImplementedException();
        }

        public void CreerUtilisateur(string Nom, string Prenom, string Telephone)
        {
            Utilisateur u = new Utilisateur() { Nom = Nom, Prenom = Prenom, Telephone = Telephone };
            bdd.Utilisateurs.Add(u);
            bdd.SaveChanges();
        }

        public void CreerVote(Utilisateur u, Restaurant r)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public void ModifierRestaurant(int id, string nom, string telephone)
        {
            Restaurant restoTrouve = bdd.Restaurants.FirstOrDefault(resto => resto.ID == id);
            if (restoTrouve != null)
            {
                restoTrouve.Nom = nom;
                restoTrouve.Telephone = telephone;
                bdd.SaveChanges();
            }
        }

        public List<Restaurant> ObtientTousLesRestaurants()
        {
            return bdd.Restaurants.ToList();
        }
    }
}