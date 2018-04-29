using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiZadBackEnd.Models
{
    [Table("sfOpstine")]
    public class sfOpstine 
    {
        private const string lenghFieldError = "Polje {0} mora imati minimum {2} karaktera a maksimum {1} !";
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";
        private const string maxlenghFieldError = "Polje {0} može imati maksimum {1} karaktera !";

        public sfOpstine()
        {
            created_at = DateTime.Now;
        }

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int OpstineID { set; get; }

        [Column("DrzaveID", Order = 1)]
        [Required(ErrorMessage = requiredFiledErrot)]
        [Display(Name = "Drzava")]
        public int DrzaveID { set; get; }

        public virtual sfDrzave Drzava { set; get; }

        [Column("Naziv", Order = 2)]
        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(100, ErrorMessage = lenghFieldError, MinimumLength = 1)]
        [Display(Name = "Naziv")]
        public string Naziv { set; get; }

        [Display(Name = "Reg Oznaka")]
        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(3, ErrorMessage = lenghFieldError, MinimumLength = 1)]
        [Column("RegOzn", Order = 3)]
        public string RegOzn { set; get; }


        [Display(Name = "Sifra poreza")]
        [Column("SifPorez", Order = 4)]
        [StringLength(50, ErrorMessage = maxlenghFieldError)]
        public string SifPorez { set; get; }

        [Display(Name = "Kontrolni broj")]
        [Column("KontBr", Order = 5)]
        [StringLength(50, ErrorMessage = maxlenghFieldError)]
        public string KontBr { set; get; }

        [Display(Name = "Poziv na broj")]
        [Column("PozivNaBr", Order = 6)]
        [StringLength(50, ErrorMessage = maxlenghFieldError)]
        public string PozivNaBr { set; get; }



        [Display(Name = "Opis")]
        [DataType(DataType.MultilineText)]
        [Column("Opis", Order = 7)]
        public string Opis { set; get; }

       // [DefaultValue(DateTime.Now)]
        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }
               

        [ScaffoldColumn(false)]
        [Display(Name = "Ime korisnika")]
        public string NameUser { set; get; }


        [ScaffoldColumn(false)]
        [Display(Name = "Datum ažuriranja")]
        public DateTime? updatedAt { set; get; }

        [Timestamp]
        [ConcurrencyCheck]
        [ScaffoldColumn(false)]
        public byte[] RowVersion { set; get; }




    }
}