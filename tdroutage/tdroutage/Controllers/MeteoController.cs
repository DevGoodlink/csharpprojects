using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tdroutage.Controllers
{
    public class MeteoController : Controller
    {
        // GET: Meteo
        public ActionResult Index(int j,int m,int a)
        {
            ViewBag.j = j;
            ViewBag.m = m;
            ViewBag.a = a;
            return View() ;
        }
    }
}