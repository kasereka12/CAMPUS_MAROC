using PrpjetPFA.Models;
namespace PrpjetPFA.Data.Services
{
    public interface IEtablissement
    {
        List<Universite> GetAllUniversite();
        List<EcolePrive> GetAllEcolePrive();
        List<Faculte> GetAllFaculte();
        List<Filiere> GetAllFiliere();
        void AddFaculte(Faculte faculte);
        void DeleteFaculte(int id);
        Faculte GetFaculteById(int id);
        void AddFiliere(Filiere filiere);
        void AddUniv(Universite universite);
        void AddEcole(EcolePrive ecolePrive);
        Universite GetUniversiteById(int id);
        EcolePrive GetEcolePriveById(int id);
        void UpdateUniversite(int id , Universite universite);
        void DeleteUniversiteById(int id);

        void DeleteEcole(int id);
        void UpdateEcole(EcolePrive ecole);
       
    }
}
