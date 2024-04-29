using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrpjetPFA.Models;

namespace PrpjetPFA.Controllers
{
    public class EtudesController : Controller
    {

        public static List<Universite> universitiesList;


        //Etudes et Filières
        public ActionResult Etudes()
        { 
            return View(); 
        }
        //Vie au Maroc
        public ActionResult vieAuMaroc()
        {
            return View();
        }
        //S'inscrire
        public ActionResult Inscrire()
        {
            return View();
        }

        public ActionResult DemandeVisa()
        {
            return View();
        }

        // GET: EtudesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EtudesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EtudesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EtudesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtudesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EtudesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtudesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EtudesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
