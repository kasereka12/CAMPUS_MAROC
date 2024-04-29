using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrpjetPFA.Models
{
    public class EcolePrive
    {
        [Key]
        public int Id { get; set; }
        public String Description { get; set; }

        public String ImageUrl { get; set; }
        public string Name { get; set; }

        public String Ville { get; set; }
        public String Adresse { get; set; }

        public String AcreditationCertification { get; set; }

        public double CoutETAideFinanciere { get; set; }

        public string Critereadmission { get; set; }
        public List<Filiere>? Filieres { get; set; }
    }
}
