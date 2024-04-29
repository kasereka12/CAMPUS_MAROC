using PrpjetPFA.Models;

namespace PrpjetPFA.Data.Services
{
    public class EtablissementService : IEtablissement
    {
        private readonly ApplicationDbContext _context;
        public EtablissementService(ApplicationDbContext context)
        {
            _context = context;
        }
        //Action pour Ecole
        public void AddEcole(EcolePrive ecolePrive)
        {
            _context.EcolePrive.Add(ecolePrive);
            _context.SaveChanges();
        }
        public List<EcolePrive> GetAllEcolePrive()
        {
            var result = _context.EcolePrive.ToList();
            return result;

        }
        public EcolePrive? GetEcolePriveById(int id)
        {
            EcolePrive? ecole = _context.EcolePrive.Find(id);
            return ecole;
        }

        public void UpdateEcole(EcolePrive ecole)
        {
            _context.EcolePrive.Update(ecole);
            _context.SaveChanges();

        }

        public void DeleteEcole(int id)
        {
            _context.EcolePrive.Remove(GetEcolePriveById(id));
            _context.SaveChanges();
        }
        //Action pour Universite
        public void AddUniv(Universite universite)
        {
            _context.Universite.Add(universite);
            _context.SaveChanges();
        }

        public void DeleteUniversiteById(int id)
        {
            _context.Universite.Remove(GetUniversiteById(id));
            _context.SaveChanges();
        }

        

        public List<Universite> GetAllUniversite()
        {
            var result = _context.Universite.ToList();
            return result;
        }

     

        public Universite  GetUniversiteById(int id)
        {
            var univ = _context.Universite.Find(id);
            return univ;
        }

      
        public void UpdateUniversite( int id , Universite universite)
        {
            _context.Universite.Update(universite);
            _context.SaveChanges(); 
        }

        //Action Faculte
        public List<Faculte> GetAllFaculte()
        {

            var result = _context.Faculte.ToList();
            return result;

        }
        public void AddFaculte(Faculte faculte)
        {

            _context.Faculte.Add(faculte);
            _context.SaveChanges();
        }
        public Faculte GetFaculteById(int id)
        {
            var result = _context.Faculte.Find(id);
            return result;
        }
        public void updateFaculte(Faculte faculte)
        {

            _context.Faculte.Update(faculte);
            _context.SaveChanges();
        }
        public void DeleteFaculte(int id)
        {
            _context.Faculte.Remove(GetFaculteById(id));
            _context.SaveChanges();
        }
        //Action Filiere

        public List<Filiere> GetAllFiliere()
        {
            var result = _context.Filiere.ToList();
            return result;
        }

       

        public void AddFiliere(Filiere filiere)
        {
            filiere.EcolePrive = GetEcolePriveById(filiere.Id);
           _context.Filiere.Add(filiere);
            _context.SaveChanges();
        }
        public Filiere GetFiliereById(int id)
        {
            var result = _context.Filiere.Find(id);
            return result;
        }
        public void updateFiliere(Filiere faculte)
        {

            _context.Filiere.Update(faculte);
            _context.SaveChanges();
        }
        public void DeleteFiliere(int id)
        {
            _context.Filiere.Remove(GetFiliereById(id));
            _context.SaveChanges();
        }
    }
}
