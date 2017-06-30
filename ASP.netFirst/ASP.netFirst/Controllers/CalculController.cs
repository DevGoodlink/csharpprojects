using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.netFirst.Controllers
{
    public class CalculController : Controller
    {
        // GET: Calcul
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Somme(int a,int b)
        {
            ViewData["valeur"] = a + b;
            ViewData["a"] = a;
            ViewData["b"] = b;
            return View();
        }
    }
}