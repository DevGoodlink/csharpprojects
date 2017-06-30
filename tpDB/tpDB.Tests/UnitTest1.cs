using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpDB.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace tpDB.Tests
{
    [TestClass]
    public class DalTest
    {
        [TestMethod]
        public void CreerRetaurant_AvecUnNouveauRestaurant_ObtientTousLesRestaurantsRenvoitBienLeRestaurant()
        {
            IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
            using (IDal dal = new Dal())
            {
                dal.CreerRestaurant("La Table d'or", "06666666");
                List<Restaurant> restaurants = dal.ObtientTousLesRestaurants();
                int a = restaurants.Count;
                Assert.IsNotNull(restaurants);
                Assert.AreEqual(a, restaurants.Count);
                Assert.AreEqual("La Table d'or", restaurants[0].Nom);
                Assert.AreEqual("06666666", restaurants[0].Telephone);
            }
        }
        [TestMethod]
        public void ModifierRestaurant_CreationNouveauRestaurantEtChangementNomEtTelephone_LaModificationEstCorreteApresRechargement()
        {
            IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
            using (IDal dal = new Dal())
            {
                dal.CreerRestaurant("La Table d'or", "06666666");
                List<Restaurant> restaurants = dal.ObtientTousLesRestaurants();
                int id = restaurants[0].ID;

                dal.ModifierRestaurant(200, "La bonne couillère", null);
                int a = restaurants.Count;
                Assert.IsNotNull(restaurants);
                Assert.AreEqual(a, restaurants.Count);
                Assert.AreEqual("La Table d'or", restaurants[0].Nom);
                Assert.AreEqual("06666666", restaurants[0].Telephone);

            }

        }
    }
}
