using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Controllers
{
    public class Historias : Controller
    {
        // GET: Historias
        public ActionResult Index()
        {
            return View();
        }

        // GET: Historias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Historias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Historias/Create
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

        // GET: Historias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Historias/Edit/5
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

        // GET: Historias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Historias/Delete/5
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
