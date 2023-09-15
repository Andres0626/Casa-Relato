using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Controllers
{
    public class Relatos : Controller
    {
        // GET: Relatos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Relatos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Relatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relatos/Create
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

        // GET: Relatos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Relatos/Edit/5
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

        // GET: Relatos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Relatos/Delete/5
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
