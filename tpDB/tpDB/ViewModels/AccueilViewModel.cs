using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpDB.ViewModels
{
    public class AccueilViewModel
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Models.Restaurant Restos { get; set; }
    }
}