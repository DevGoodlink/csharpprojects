using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FormationController : Controller
    {
        // GET: Formation
        public ActionResult Index()
        {
            List<Formation> lstf = new List<Formation>()
            {
                new Formation(){ID=10,DateObtention=new DateTime(2003,6,25),Libelle="Bac",Etablissement="Lycée",Description="Sciences",Mention="Passable"},
                new Formation(){ID=20,DateObtention=new DateTime(2005,6,25),Libelle="Bac + 2",Etablissement="ISTA",Description="Systèmes d'information",Mention="A bien"},
                new Formation(){ID=30,DateObtention=new DateTime(2016,06,25),Libelle="Bac + 3",Etablissement="UPF",Description="Génie Informatique",Mention="Très bien"}
            };
            //accés à la bd
            ViewData["Formation"] = lstf;
            return View();
        }
        public ActionResult FormationPro()
        {
            List<FormationPro> lstf = new List<FormationPro>()
            {
                new FormationPro(){ID=10,DateFormation=new DateTime(2005,6,25),Libelle="TSSI",Etablissement="ISTA",Description="Systèmes d'information"},
            };
            ViewData["Fpro"] = lstf;
            return View();
        }
    }
}