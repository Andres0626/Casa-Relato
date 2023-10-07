using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Controllers
{
    public class TiendaController : Controller
    {
        // GET: TiendaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TiendaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TiendaController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiendaController1/Create
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

        // GET: TiendaController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TiendaController1/Edit/5
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

        // GET: TiendaController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TiendaController1/Delete/5
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
