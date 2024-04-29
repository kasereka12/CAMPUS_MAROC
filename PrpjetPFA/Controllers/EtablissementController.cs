using Microsoft.AspNetCore.Mvc;
using PrpjetPFA.Data.Services;
using PrpjetPFA.Models;

namespace PrpjetPFA.Controllers
{

    public class EtablissementController : Controller
    {
        private readonly IEtablissement etablissement;
        private List<Universite> universites;
        private List<EcolePrive> ecoles;
        private List<Faculte> facultes;
        private List<Filiere> filiere;
        private Etablissement etablissements;
        public EtablissementController(IEtablissement etablissement)
        {
            universites = new List<Universite>();
            ecoles = new List<EcolePrive>();
            facultes = new List<Faculte>();
            filiere = new List<Filiere>();
            etablissements = new Etablissement();

            this.etablissement = etablissement;
        }

        public IActionResult Index()
        {
            universites = etablissement.GetAllUniversite();
            ViewBag.Universites = universites;
            return View();
        }
        public IActionResult EcoleAll()
        {
          
            ecoles = etablissement.GetAllEcolePrive();
            ViewBag.Universites = ecoles;
            return View();
        }
        [HttpGet]
        public IActionResult Ajouter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ajouter([Bind("Name , Description , ImageUrl ,Ville , Adresse ,AcreditationCertification,CoutETAideFinanciere,Critereadmission")] Universite universite)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            etablissement.AddUniv(universite);

            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Universite u = etablissement.GetUniversiteById(id);
            if (u == null) return RedirectToAction("Index");
            return View(u);
        }
        [HttpPost]
        public IActionResult Edit(int id,[Bind("Name , Description , ImageUrl ,Ville , Adresse ,AcreditationCertification,CoutETAideFinanciere,Critereadmission")] Universite universite)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            etablissement.UpdateUniversite(id,universite);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            etablissement.DeleteUniversiteById(id);
            return RedirectToAction("Index");
        }

        //ECOLE
        [HttpGet]
        public IActionResult AjouterEcole()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AjouterEcole([Bind("Name , Description , ImageUrl ,Ville , Adresse ,AcreditationCertification,CoutETAideFinanciere,Critereadmission")] EcolePrive ecole)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            etablissement.AddEcole(ecole);

            return RedirectToAction("EcoleAll");
        }
        public IActionResult DeleteEcole(int id)
        {
            etablissement.DeleteEcole(id);
            return RedirectToAction("EcoleAll");
        }
        [HttpGet]
        public IActionResult EditEcole()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditEcole([Bind("Name , Description , ImageUrl ,Ville , Adresse ,AcreditationCertification,CoutETAideFinanciere,Critereadmission")] EcolePrive ecole)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            etablissement.UpdateEcole(ecole);
            return RedirectToAction("EcoleAll");
        }
        //Faculte
        public IActionResult Faculte()
        {
            facultes = etablissement.GetAllFaculte();
            ViewBag.Facultes = facultes; 
            return View();
        }
        [HttpGet]
        public IActionResult AjouterFaculte()
        {
            universites = etablissement.GetAllUniversite();
            ViewBag.Universites = universites;
            return View();
        }
        [HttpPost]
        public IActionResult AjouterFaculte([Bind("Name,Ville,Adresse,Critereadmission,UniversiteId")]Faculte faculte)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            etablissement.AddFaculte(faculte);
            return RedirectToAction("Faculte");
        }
        [HttpGet]
        public IActionResult EditFaculte()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditFaculte([Bind("Name,Ville,Adresse,Critereadmission,UniversiteId")] Faculte faculte)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Faculte");
        }

        public IActionResult DeleteFaculte(int id)
        {
           
            return RedirectToAction("Faculte");
        }
        //Filiere 
        public IActionResult Filiere()
        {
            filiere = etablissement.GetAllFiliere();
           
            ViewBag.Filieres = filiere;
            return View();
        }
        public IActionResult AjouterFiliere()
        {
            etablissements.Faculte = etablissement.GetAllFaculte();
            etablissements.EcolePrive = etablissement.GetAllEcolePrive();
            return View(etablissements);
        }
        [HttpPost]
        public IActionResult AjouterFiliere([Bind("Name,DescriptionFiliere,ContenuDuProgramme,Debouche,ConditionDadmission,Cout,FaculteId,EcoleId")] Filiere filiere)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            etablissement.AddFiliere(filiere);
            return RedirectToAction("Filiere");
        }
        public IActionResult EditFiliere()
        {
            return View();
        }
        public IActionResult EditFiliere([Bind("Name,DescriptionFiliere,ContenuDuProgramme,Debouche,ConditionDadmission,Cout,FaculteId,EcoleId")] Filiere filiere)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Filiere");
        }

        public IActionResult DeleteFiliere(int id)
        {
            
            return RedirectToAction("Filiere");
        }
    }
}
