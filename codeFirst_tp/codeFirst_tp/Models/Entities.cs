using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace codeFirst_tp.Models
{
    [Table("MEDECINS",Schema ="dbo")]
    class Medecin
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }
        [Required]
        [MaxLength(5)]
        [Column("TITRE")]
        public string Titre { get; set; }
        [Required]
        [MaxLength(20)]
        [Column("NOM")]
        public string Nom { get; set; }
        [Required]
        [MaxLength(20)]
        [Column("PRENOM")]
        public string Prenom { get; set; }
        [Required]
        [Column("DATENAISS")]
        public DateTime DateNais { get; set; }
        public List<Operation> Operations { get; set; }
    }
    [Table("OPERATION", Schema = "dbo")]
    class Operation
    {
        [Key]
        [Column("ID")]
        public int? ID { get; set; }
        [Required]
        [Column("Hdebut")]
        public int HeureDebut { get; set; }
        [Required]
        [Column("Hfin")]
        public int HeureFin { get; set; }
        [Required]
        public virtual Medecin medecin { get; set; }

    }
}
