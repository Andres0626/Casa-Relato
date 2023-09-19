using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using casa_relato.Models;

namespace casa_relato.Controllers
{
    public class BibliotecaController : Controller
    {

        private readonly IConfiguration _configuration;

        public BibliotecaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            try
            {


            
            string Connection = _configuration.GetConnectionString("ConnectionStrings");
            var Biblioteca = new List<BibliotecaViewModel>();

                using (SqlConnection connections = new SqlConnection(Connection))
            {
                    string command = $@"Select * from Biblioteca";

                    using (SqlCommand cmd = new SqlCommand(command, connections))
                    {
                        connections.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                var biblioteca = new BibliotecaViewModel
                                {
                                    ID = (int)reader["ID"],
                                    Año = (Int64)reader["Año"],
                                    Lugar = (string)reader["Lugar"],
                                    Editorial = (string)reader["Editorial"],
                                    Titulo = (string)reader["Titulo"],
                                    Autor = (string)reader["Autor"],
                                    Categoria = (string)reader["Categoria"],
                                    TipoDePublicacion = (string)reader["Tipo_de_Publicacion"],
                                    Paginas = (Int64)reader["Paginas"]

                                };

                                Biblioteca.Add(biblioteca);

                            }

                        }
                    }

            }


            return View(Biblioteca);
            }

            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
