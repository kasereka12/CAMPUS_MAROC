using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrpjetPFA.Models
{
    public class Faculte {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public int UniversiteId { get; set; }
      
        public string Name { get; set; }

        public String Ville { get; set; }
        public String Adresse { get; set; }

        public string Critereadmission { get; set; }

        public Universite? Universite { get; set; }

        public List<Filiere>? Filieres { get; set; }
    }
}
