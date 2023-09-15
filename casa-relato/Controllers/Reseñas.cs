using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Controllers
{
    public class Reseñas : Controller
    {
        // GET: Reseñas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reseñas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reseñas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reseñas/Create
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

        // GET: Reseñas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reseñas/Edit/5
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

        // GET: Reseñas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reseñas/Delete/5
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
