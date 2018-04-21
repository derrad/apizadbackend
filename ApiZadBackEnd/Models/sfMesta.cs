using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ApiZadBackEnd.Models
{
    [Table("sfMesta")]
    public class sfMesta 
    {

        private const string lenghFieldError = "Polje {0} mora imati minimum {2} karaktera a maksimum {1} !";
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";
        private const string maxlenghFieldError = "Polje {0} može imati maksimum {1} karaktera !";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int MestaID { set; get; }

        [Column("OpstineID", Order = 1)]
        [Required(ErrorMessage = requiredFiledErrot)]
        [Display(Name = "Opština")]
        public int OpstineID { set; get; }

        public virtual sfOpstine Opstina { set; get; }

        [Column("Naziv", Order = 2)]
        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(100, ErrorMessage = lenghFieldError, MinimumLength = 1)]
        [Display(Name = "Naziv")]
        // [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Naziv { set; get; }

        [Display(Name = "Ptt")]
        [Column("Ptt", Order = 3)]
        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(50, ErrorMessage = maxlenghFieldError)]
        public string Ptt { set; get; }

        [Display(Name = "Opis")]
        [DataType(DataType.MultilineText)]
        [Column("Opis", Order = 4)]
         public string Opis { set; get; }

        [ScaffoldColumn(false)]
        [Display(Name = "Datum kreiranja")]
        public DateTime? created_at { set; get; }

        public sfMesta()
        {
        }

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