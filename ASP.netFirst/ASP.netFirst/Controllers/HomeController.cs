using ASP.netFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.netFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult blog(string nom,string prenom)
        {
            
            if (string.IsNullOrWhiteSpace(nom))
            {
                return View("Error");
            }
            ViewData["Nom"] = nom;
            ViewBag.Prenom = prenom;
            return View();
            //return @"<h1>Résultat</h1>"+"<hr>Bonjour "+nom+" nous somme le "+ DateTime.Now;
        }
        public  ActionResult listClients()
        {
            Clients cts =new  Clients();
           // ViewData["clients"] = cts.ListeClients();
            return View("listClients");
        }
        public ActionResult ChercheClient(string nom)
        {
            ViewData["nom"] = nom;
            Clients cts = new Clients();

            Client c1 = cts.ListeClients().FirstOrDefault(c => c.Nom == nom);
            if (c1!=null){
                ViewData["nom"] = c1.Nom;
                ViewData["age"] = c1.Age;
                return View("found");
            }
            return View("notfound");
            
        }
    }
}