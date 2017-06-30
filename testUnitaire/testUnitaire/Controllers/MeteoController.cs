using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testUnitaire.Controllers
{
    public class MeteoController : Controller
    {
        // GET: Meteo
        public ActionResult Index()
        {
            return View();
        }
    }
}