using casa_relato.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace casa_relato.Controllers
{
    public class LogueoController : Controller
    {
        private readonly IConfiguration _configuration;

        public LogueoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
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
                                // Las credenciales son válidas
                                return RedirectToAction("Home"); // Redirigir a una página de acceso exitoso
                            }
                        }
                    }
                }
                return RedirectToAction("AccesoDenegado");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }
    }
}
