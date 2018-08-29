using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("POPDV9a")]
    public class POPDV9a
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDV9a_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }

        public decimal Iznos_9a1 { set; get; }
        public decimal Iznos_9a2 { set; get; }
        public decimal Iznos_9a3 { set; get; }
        public decimal Iznos_9a4 { set; get; }


        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "ID korisnika")]
        [DefaultValue(0)]
        public int KORISNIK_ID { set; get; }


    }
}