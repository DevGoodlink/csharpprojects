using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpDB.Models
{
    public class Sondage
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Vote> Vote { get; set; }
    }
}