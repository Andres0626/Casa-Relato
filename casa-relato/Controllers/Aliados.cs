using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Controllers
{
    public class Aliados : Controller
    {
        // GET: Aliados
        public ActionResult Index()
        {
            return View();
        }

        // GET: Aliados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aliados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aliados/Create
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

        // GET: Aliados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aliados/Edit/5
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

        // GET: Aliados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aliados/Delete/5
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
