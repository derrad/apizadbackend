using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("PoPdvTab3")]
    public class PoPdvTab3
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int PoPdvTab3ID { set; get; }

        public PoPdvTab3()
        {

        }

        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(10, ErrorMessage = "Duzina do 10")]
        public string Oznaka { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(100, ErrorMessage = "Duzina do 100")]
        public string Desc { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public decimal OS_osnov { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public decimal OS_pdv { set; get; }


        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public decimal PS_osnov { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public decimal PS_pdv { set; get; }


        [DefaultValue(1)]
        [Required(ErrorMessage = requiredFiledErrot)]
        public int RedPrikaza { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(false)]
        public bool BoldPozic { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "Ime korisnika")]
        public int KORISNIK_ID { set; get; }
    }
}