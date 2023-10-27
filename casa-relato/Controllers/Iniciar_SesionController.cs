
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace casa_relato.Controllers
{
    public class Iniciar_SesionController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        private readonly IConfiguration _configuration;

        public Iniciar_SesionController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult OnPost(string username, string password)
        {
            try
            {
                string Connection = _configuration.GetConnectionString("ConnectionStrings");
                using (var connection = new SqlConnection(Connection))
                {
                    connection.Open();

                    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Username", username));
                        command.Parameters.Add(new SqlParameter("@Password", password));

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return View();
                            }
                            else
                            {
                                return View(reader);
                            }
                        }
                    }
                }

                }catch (Exception ex) 
            
            {
                

            }
            return View();
        }
    }
}
