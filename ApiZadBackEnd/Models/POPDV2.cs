using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ApiZadBackEnd.Models
{
    [Table("POPDV2")]
    public class POPDV2
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDV2_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }

        public decimal Iznos_21 { set; get; }
        public decimal Iznos_22 { set; get; }
        public decimal Iznos_23 { set; get; }
        public decimal Iznos_24 { set; get; }
        public decimal Iznos_25 { set; get; }
        public decimal Iznos_26 { set; get; }
        public decimal Iznos_27 { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "ID korisnika")]
        [DefaultValue(0)]
        public int KORISNIK_ID { set; get; }

    }
}