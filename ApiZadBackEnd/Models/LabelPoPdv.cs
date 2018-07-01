using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ApiZadBackEnd.Models
{
    [Table("LabelPoPdv")]
    public class LabelPoPdv
    {
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int LabelPoPdvID { set; get; }

        public LabelPoPdv()
        {

        }

        public int TableID { get; set; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public System.Int16 ObrPolje { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public System.Int16 UnosPolje { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public System.Int16 NaslovPolje { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(10, ErrorMessage = "Duzina do 10")]
        public string Oznaka { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(250, ErrorMessage = "Duzina do 250")]
        public string ParentDesc { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(250, ErrorMessage = "Duzina do 250")]
        public string Desc { set; get; }

        public string Prikaz { set; get; }

        public string ImeTab { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public System.Int16 UlazPdv { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [DefaultValue(0)]
        public System.Int16 IzlazPdv { set; get; }

        public string Napomena { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "Ime korisnika")]
        public int KORISNIK_ID { set; get; }

    }
}