
using casa_relato.Common;
using casa_relato.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace casa_relato.Controllers
{
    public class Iniciar_SesionController : Controller
    {

        private readonly IConfiguration _configuration;

        public Iniciar_SesionController(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CerrarSesion()
        {
            CommonUtils.SetSuccess(false);
            return View("Index");
        }

        [HttpPost]
        public IActionResult inicio(string username, string password)
        {
            try
            {
                string Connection = _configuration.GetConnectionString("ConnectionStrings");

                using (SqlConnection connections = new SqlConnection(Connection))
                {
                    string command = $@"SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(command, connections))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        connections.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CommonUtils.SetSuccess(true);
                                return RedirectToAction("index");
                            }
                        }
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}
