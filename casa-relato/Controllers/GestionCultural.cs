using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Controllers
{
    public class GestionCultural : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
