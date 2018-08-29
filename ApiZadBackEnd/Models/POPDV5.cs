using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("POPDV5")]
    public class POPDV5
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDV5_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }

        public decimal Iznos_51 { set; get; }
        public decimal Iznos_52 { set; get; }
        public decimal Iznos_53 { set; get; }
        public decimal Iznos_54 { set; get; }
        public decimal Iznos_55 { set; get; }
        public decimal Iznos_56 { set; get; }
        public decimal Iznos_57 { set; get; }



        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "ID korisnika")]
        [DefaultValue(0)]
        public int KORISNIK_ID { set; get; }


    }
}