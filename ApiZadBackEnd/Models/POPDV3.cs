using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("POPDV3")]
    public class POPDV3
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDV3_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }

        public decimal Iznos_311 { set; get; }
        public decimal Iznos_312 { set; get; }
        public decimal Iznos_313 { set; get; }
        public decimal Iznos_314 { set; get; }
        public decimal Iznos_321 { set; get; }
        public decimal Iznos_322 { set; get; }
        public decimal Iznos_323 { set; get; }
        public decimal Iznos_324 { set; get; }
        public decimal Iznos_331 { set; get; }
        public decimal Iznos_333 { set; get; }
        public decimal Iznos_341 { set; get; }
        public decimal Iznos_343 { set; get; }
        public decimal Iznos_351 { set; get; }
        public decimal Iznos_352 { set; get; }
        public decimal Iznos_353 { set; get; }
        public decimal Iznos_354 { set; get; }
        public decimal Iznos_361 { set; get; }
        public decimal Iznos_362 { set; get; }
        public decimal Iznos_363 { set; get; }
        public decimal Iznos_364 { set; get; }
        public decimal Iznos_371 { set; get; }
        public decimal Iznos_372 { set; get; }
        public decimal Iznos_373 { set; get; }
        public decimal Iznos_374 { set; get; }
        public decimal Iznos_381 { set; get; }
        public decimal Iznos_382 { set; get; }
        public decimal Iznos_383 { set; get; }
        public decimal Iznos_384 { set; get; }
        public decimal Iznos_391 { set; get; }
        public decimal Iznos_392 { set; get; }
        public decimal Iznos_393 { set; get; }
        public decimal Iznos_394 { set; get; }
        public decimal Iznos_3102 { set; get; }
        public decimal Iznos_3104 { set; get; }


        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "ID korisnika")]
        [DefaultValue(0)]
        public int KORISNIK_ID { set; get; }
    }
}