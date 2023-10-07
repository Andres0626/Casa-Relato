//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
//using casa_relato.Models;
//using System.Linq;

//public class IniciarSesionController : Controller
//{
//    private readonly IConfiguration _configuration;

//    public IniciarSesionController(IConfiguration configuration)
//    {
//        _configuration = configuration;
//    }

//    [HttpPost]
//    public IActionResult Login(IniciarSesionModel model)
//    {
//        if (ModelState.IsValid)
//        {
//            var user = _configuration.Users
//                .FirstOrDefault(u => u.UserName == model.UserName && u.Password == model.Password);

//            if (user != null)
//            {
//                // Usuario válido, aquí podrías realizar más acciones, como establecer la sesión
//                // o redirigir al usuario a otra página
//                return RedirectToAction("Index", "Home"); // Cambia esto según tu lógica
//            }
//            else
//            {
//                ModelState.AddModelError(string.Empty, "Usuario o contraseña incorrectos");
//            }
//        }

//        // Si llegas aquí, significa que hubo un error, vuelve a la vista de inicio de sesión
//        return View("Login", model);
//    }
//}
