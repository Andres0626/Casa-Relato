using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Controllers
{
    public class Quienes_SomosController : Controller
    {
        // GET: Quienes_SomosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Quienes_SomosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quienes_SomosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quienes_SomosController/Create
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

        // GET: Quienes_SomosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quienes_SomosController/Edit/5
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

        // GET: Quienes_SomosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quienes_SomosController/Delete/5
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
