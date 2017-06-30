using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tpDB.Models
{
    [Table("Restaurant")]
    public class Restaurant
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20)]
        public string Nom { get; set; }
        [MaxLength(10)]
        public string Telephone { get; set; }
    }
}