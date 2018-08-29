using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("POPDV4")]
    public class POPDV4
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDV4_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }


        public decimal Iznos_4111 { set; get; }
        public decimal Iznos_4121 { set; get; }
        public decimal Iznos_4131 { set; get; }
        public decimal Iznos_4142 { set; get; }
        public decimal Iznos_4211 { set; get; }
        public decimal Iznos_4212 { set; get; }
        public decimal Iznos_4221 { set; get; }
        public decimal Iznos_4222 { set; get; }
        public decimal Iznos_4231 { set; get; }
        public decimal Iznos_4232 { set; get; }
        public decimal Iznos_4243 { set; get; }
        public decimal Iznos_4244 { set; get; }


        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "ID korisnika")]
        [DefaultValue(0)]
        public int KORISNIK_ID { set; get; }


    }
}