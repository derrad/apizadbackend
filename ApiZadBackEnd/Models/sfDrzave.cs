using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiZadBackEnd.Models
{
    [Table("sfDrzave")]
    public class sfDrzave
    {
        private const string lenghFieldError = "Polje {0} mora imati minimum {2} karaktera a maksimum {1} !";
        private const string requiredFiledErrot = "Za polje {0} je obavezan unos !!!";

        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int DrzaveID { set; get; }

        public sfDrzave()
        {
        }

        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(3, ErrorMessage = lenghFieldError, MinimumLength = 1)]
        [Display(Name = "Kod drzave")]
        [Column("KodDrzave", Order = 1)]
        public string KodDrzave { set; get; }

        [Required(ErrorMessage = requiredFiledErrot)]
        [StringLength(100, ErrorMessage = lenghFieldError, MinimumLength = 1)]
        [Display(Name = "Naziv drzave")]
        [Column("Naziv", Order = 2)]
        public string Naziv { set; get; }

        [Display(Name = "Clan Eu")]
        [Column("EuClan", Order = 3)]
        public bool EuClan { set; get; }

        [Display(Name = "Opis")]
        [DataType(DataType.MultilineText)]
        [Column("Opis", Order = 4)]
        public string Opis { set; get; }

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