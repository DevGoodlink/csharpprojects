using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsomateurWSCreditCard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Validator()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Valider(string cn,string ed,string type, int vn,string token)
        {

            ws.creditCard cc = new ws.creditCard() { cn = vn, expiryDate = ed, number = cn, type = type };
            ws.CreditCardWSClient wsc = new ws.CreditCardWSClient();
            var result = wsc.validate(cc,token);
            string message;
            if (result == true)
                message= "Carte de crédit valide";
            else
                message= "Carte de crédit invalide";
            ViewData["message"] = message;
            ViewData["Cc"] = cn;
            ViewData["token"] = token;
            return View();
        }
    }
}