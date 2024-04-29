using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrpjetPFA.Models
{
    public class Filiere
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public int? FaculteId { get; set; }

        [ForeignKey(nameof(Id))]    
        public int? EcoleId { get; set; }
        public string Name { get; set; }
        public String DescriptionFiliere { get; set; }
        public String ContenuDuProgramme { get; set; }
        public String Debouche { get; set; }
        public string ConditionDadmission { get; set;}

        public double Cout { get; set; }

      
        public Faculte? Faculte { get; set; }
     
        public EcolePrive? EcolePrive { get; set; }
    }
}
