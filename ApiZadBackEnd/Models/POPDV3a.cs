using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("POPDV3a")]
    public class POPDV3a
    {

        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDV3a_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }

        public decimal Iznos_3a11 { set; get; }
        public decimal Iznos_3a12 { set; get; }
        public decimal Iznos_3a21 { set; get; }
        public decimal Iznos_3a22 { set; get; }
        public decimal Iznos_3a31 { set; get; }
        public decimal Iznos_3a32 { set; get; }
        public decimal Iznos_3a41 { set; get; }
        public decimal Iznos_3a42 { set; get; }
        public decimal Iznos_3a51 { set; get; }
        public decimal Iznos_3a52 { set; get; }
        public decimal Iznos_3a61 { set; get; }
        public decimal Iznos_3a62 { set; get; }
        public decimal Iznos_3a71 { set; get; }
        public decimal Iznos_3a72 { set; get; }
        public decimal Iznos_3a81 { set; get; }
        public decimal Iznos_3a82 { set; get; }
        public decimal Iznos_3a91 { set; get; }
        public decimal Iznos_3a92 { set; get; }


        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "ID korisnika")]
        [DefaultValue(0)]
        public int KORISNIK_ID { set; get; }
    }
}