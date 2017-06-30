using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Check(string login, string password)
        {
            if (login.Equals("admin") && password.Equals("admin"))
                return View("Panel");
            else
                return View("Error");
        }
    }
}