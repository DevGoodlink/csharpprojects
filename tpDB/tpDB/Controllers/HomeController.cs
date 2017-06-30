using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tpDB.Models;
using tpDB.ViewModels;

namespace tpDB.Controllers
{
    public class HomeController : Controller
    {

        IDal d = new Dal();
        // GET: Home
        public ActionResult Index()
        {
            Restaurant r = new Restaurant() { Nom="La maison blanche",Telephone="0642259866"};
            AccueilViewModel a = new AccueilViewModel(){ Message = "Bon restaurant français, une cave bien garnie et une cuisine raffinée",
                                                         Date =new DateTime(2016,12,25),
                                                         Restos=r };

            return View(a);
        }
        public ActionResult Utilisateur()
        {
            return View();
        }
        public ActionResult Restaurant()
        {
            return View();
        }
        public ActionResult ListRestaurant()
        {
            List<Restaurant> lst = d.ObtientTousLesRestaurants();
            return View(lst);
        }
        public ActionResult CreateRestaurant(string nom,string telephone)
        {
            d.CreerRestaurant(nom, telephone);
            return View();
        }
    }
}