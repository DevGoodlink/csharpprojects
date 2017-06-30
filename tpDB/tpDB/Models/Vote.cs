using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpDB.Models
{
    public class Vote
    {
        public int ID { get; set; }
        public virtual Restaurant Resto { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}