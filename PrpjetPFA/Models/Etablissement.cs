using PrpjetPFA.Enum;
namespace PrpjetPFA.Models
{
    public class Etablissement
    {
        
        public int Id;
        public string Name { get; set; }

        public String Ville { get; set; }
        public String Adresse { get; set; }

        public TypeEtablissement typeEtablissement { get; set; }

        public List<String> Departements { get; set; }


    }
}
