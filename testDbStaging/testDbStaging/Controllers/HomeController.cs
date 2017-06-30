using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using testDbStaging.Models;

namespace testDbStaging.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<AGING> lstAging = new List<AGING>();
            IEnumerable<PURPOSE> lstPpse = new List<PURPOSE>();
            IEnumerable<SECTOR> lstSector = new List<SECTOR>();
            IEnumerable<MFI_DETAILS> lstMfi = new List<MFI_DETAILS>();

            using (Entities ctx = new Entities())
            {
                lstAging = (from a in ctx.AGINGs select a).ToList();
                lstPpse = (from p in ctx.PURPOSEs select p).ToList();
                lstSector = (from s in ctx.SECTORs select s).ToList();
                lstMfi = (from m in ctx.MFI_DETAILS select m).ToList();

            }

            List<SelectListItem> SelectListAging = new List<SelectListItem>();
            foreach (var a in lstAging)
            {
                SelectListAging.Add(new SelectListItem() { Value = "" + a.AGING_ID, Text = a.AGING_DESCRIPTION });
            }
            //SelectListAging.Add(new SelectListItem() { Value = "null", Text = "by aging", Selected = true });
            ViewBag.SelectListAging = SelectListAging;

            List<SelectListItem> SelectListPurpose = new List<SelectListItem>();
            foreach (var p in lstPpse)
            {
                SelectListPurpose.Add(new SelectListItem() { Value = "" + p.PURPOSE_ID, Text = p.PURPOSE_DESCRIPTION });
            }
            //SelectListPurpose.Add(new SelectListItem() { Value = "null", Text = "by purpose", Selected = true });
            ViewBag.SelectListPorpose = SelectListPurpose;

            List<SelectListItem> SelectListSector = new List<SelectListItem>();
            foreach (var s in lstSector)
            {
                SelectListSector.Add(new SelectListItem() { Value = "" + s.SECTOR_ID, Text = s.SECTOR_DESCRIPTION });
            }
            //SelectListSector.Add(new SelectListItem() { Value = "null", Text = "by sector", Selected = true });
            ViewBag.SelectListSector = SelectListSector;

            List<SelectListItem> SelectListMfi = new List<SelectListItem>();
            foreach (var m in lstMfi)
            {
                SelectListMfi.Add(new SelectListItem() { Value = "" + m.MFI_id, Text = m.MFI_NAME });
            }
            //SelectListMfi.Add(new SelectListItem() { Value = "null", Text = "by mfi", Selected = true });
            ViewBag.SelectListMfi = SelectListMfi;



            return View();
        }

        public String Action()
        {
            List<CLIENT_SEXE_BY_MFI_Result> lst = new List<CLIENT_SEXE_BY_MFI_Result>();
            using (Entities ctx = new Entities())
            {
                foreach (var mfi in ctx.MFI_DETAILS)
                {
                    CLIENT_SEXE_BY_MFI_Result result = ctx.CLIENT_SEXE_BY_MFI(mfi.MFI_id).FirstOrDefault();
                    if (result != null)
                        lst.Add(result);
                }



            }


            var json = JsonConvert.SerializeObject(lst);
            // ViewBag.json = 
            return json;
        }


    }
}