using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("POPDV")]
    public class POPDV
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int POPDVID { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        public int prPPPDV_ID { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(10, ErrorMessage = "Duzina do 10")]
        public string Oznaka { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(200, ErrorMessage = "Duzina do 200")]
        public string Desc { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(20, ErrorMessage = "Duzina do 10")]
        public string Tabela { set; get; }

        /*POPDV1*/
        public decimal Iznos_11 { set; get; }
        public decimal Iznos_12 { set; get; }
        public decimal Iznos_14 { set; get; }
        public decimal Iznos_15 { set; get; }
        public decimal Iznos_16 { set; get; }
        public decimal Iznos_17 { set; get; }


        /*POPDV2*/
        public decimal Iznos_21 { set; get; }
        public decimal Iznos_22 { set; get; }
        public decimal Iznos_23 { set; get; }
        public decimal Iznos_24 { set; get; }
        public decimal Iznos_25 { set; get; }
        public decimal Iznos_26 { set; get; }
        public decimal Iznos_27 { set; get; }

        /*POPDV3*/
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

        /*POPDV3a*/
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

        /*POPDV4*/
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

        /*POPDV5*/
        public decimal Iznos_51 { set; get; }
        public decimal Iznos_52 { set; get; }
        public decimal Iznos_53 { set; get; }
        public decimal Iznos_54 { set; get; }
        public decimal Iznos_55 { set; get; }
        public decimal Iznos_56 { set; get; }
        public decimal Iznos_57 { set; get; }

        /*POPDV6*/
        public decimal Iznos_61 { set; get; }
        public decimal Iznos_6211 { set; get; }
        public decimal Iznos_6212 { set; get; }
        public decimal Iznos_6221 { set; get; }
        public decimal Iznos_6222 { set; get; }
        public decimal Iznos_6231 { set; get; }
        public decimal Iznos_6232 { set; get; }
        public decimal Iznos_63 { set; get; }
        public decimal Iznos_64 { set; get; }

        /*POPDV7*/
        public decimal Iznos_711 { set; get; }
        public decimal Iznos_721 { set; get; }
        public decimal Iznos_732 { set; get; }
        public decimal Iznos_742 { set; get; }

        /*POPDV8*/
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

        /*POPDV9*/
        public decimal Iznos_9 { set; get; }

        /*POPDV9a*/
        public decimal Iznos_9a1 { set; get; }
        public decimal Iznos_9a2 { set; get; }
        public decimal Iznos_9a3 { set; get; }
        public decimal Iznos_9a4 { set; get; }

        /*POPDV10*/
        public decimal Iznos_10 { set; get; }

        /*POPDV11*/
        public decimal Iznos_111 { set; get; }
        public decimal Iznos_112 { set; get; }
        public decimal Iznos_113 { set; get; }
    }
}