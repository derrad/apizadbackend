using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("POPDV6")]
    public class POPDV6
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDV6_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }


        public decimal Iznos_61 { set; get; }
        public decimal Iznos_6211 { set; get; }
        public decimal Iznos_6212 { set; get; }
        public decimal Iznos_6221 { set; get; }
        public decimal Iznos_6222 { set; get; }
        public decimal Iznos_6231 { set; get; }
        public decimal Iznos_6232 { set; get; }
        public decimal Iznos_63 { set; get; }
        public decimal Iznos_64 { set; get; }


        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "ID korisnika")]
        [DefaultValue(0)]
        public int KORISNIK_ID { set; get; }


    }
}