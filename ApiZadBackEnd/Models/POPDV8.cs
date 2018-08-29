using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("POPDV8")]
    public class POPDV8
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDV8_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }


        public decimal Iznos_8a11 { set; get; }
        public decimal Iznos_8a12 { set; get; }
        public decimal Iznos_8a13 { set; get; }
        public decimal Iznos_8a14 { set; get; }
        public decimal Iznos_8a21 { set; get; }
        public decimal Iznos_8a22 { set; get; }
        public decimal Iznos_8a23 { set; get; }
        public decimal Iznos_8a24 { set; get; }
        public decimal Iznos_8a31 { set; get; }
        public decimal Iznos_8a32 { set; get; }
        public decimal Iznos_8a33 { set; get; }
        public decimal Iznos_8a34 { set; get; }
        public decimal Iznos_8a41 { set; get; }
        public decimal Iznos_8a42 { set; get; }
        public decimal Iznos_8a43 { set; get; }
        public decimal Iznos_8a44 { set; get; }
        public decimal Iznos_8a51 { set; get; }
        public decimal Iznos_8a52 { set; get; }
        public decimal Iznos_8a53 { set; get; }
        public decimal Iznos_8a54 { set; get; }
        public decimal Iznos_8a61 { set; get; }
        public decimal Iznos_8a63 { set; get; }
        public decimal Iznos_8a71 { set; get; }
        public decimal Iznos_8a72 { set; get; }
        public decimal Iznos_8a73 { set; get; }
        public decimal Iznos_8a74 { set; get; }
        public decimal Iznos_8a82 { set; get; }
        public decimal Iznos_8a84 { set; get; }

        public decimal Iznos_8b11 { set; get; }
        public decimal Iznos_8b12 { set; get; }
        public decimal Iznos_8b21 { set; get; }
        public decimal Iznos_8b22 { set; get; }
        public decimal Iznos_8b31 { set; get; }
        public decimal Iznos_8b32 { set; get; }
        public decimal Iznos_8b41 { set; get; }
        public decimal Iznos_8b42 { set; get; }
        public decimal Iznos_8b51 { set; get; }
        public decimal Iznos_8b52 { set; get; }
        public decimal Iznos_8b61 { set; get; }
        public decimal Iznos_8b62 { set; get; }
        public decimal Iznos_8b71 { set; get; }
        public decimal Iznos_8b72 { set; get; }

        public decimal Iznos_8v1 { set; get; }
        public decimal Iznos_8v2 { set; get; }
        public decimal Iznos_8v3 { set; get; }
        public decimal Iznos_8v4 { set; get; }

        public decimal Iznos_8g11 { set; get; }
        public decimal Iznos_8g12 { set; get; }
        public decimal Iznos_8g21 { set; get; }
        public decimal Iznos_8g22 { set; get; }
        public decimal Iznos_8g31 { set; get; }
        public decimal Iznos_8g32 { set; get; }
        public decimal Iznos_8g41 { set; get; }
        public decimal Iznos_8g42 { set; get; }
        public decimal Iznos_8g51 { set; get; }
        public decimal Iznos_8g52 { set; get; }
        public decimal Iznos_8g61 { set; get; }
        public decimal Iznos_8g62 { set; get; }

        public decimal Iznos_8d1 { set; get; }
        public decimal Iznos_8d2 { set; get; }
        public decimal Iznos_8d3 { set; get; }
        public decimal Iznos_8dj { set; get; }

        public decimal Iznos_8e1 { set; get; }
        public decimal Iznos_8e2 { set; get; }
        public decimal Iznos_8e3 { set; get; }
        public decimal Iznos_8e4 { set; get; }
        public decimal Iznos_8e5 { set; get; }
        public decimal Iznos_8e6 { set; get; }


        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "ID korisnika")]
        [DefaultValue(0)]
        public int KORISNIK_ID { set; get; }


    }
}