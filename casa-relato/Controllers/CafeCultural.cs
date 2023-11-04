using Microsoft.AspNetCore.Mvc;

namespace casa_relato.Controllers
{
    public class CafeCultural : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
