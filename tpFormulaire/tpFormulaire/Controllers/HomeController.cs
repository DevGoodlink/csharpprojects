using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tpFormulaire.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult MyAction() {
            if (Request["a"]!=null)
            {
                ViewBag.id = Request["nom"];
            }else if (Request["b"] != null)
            {
                ViewBag.id = Request["prenom"];
            }
            return View();

        }


    }
}