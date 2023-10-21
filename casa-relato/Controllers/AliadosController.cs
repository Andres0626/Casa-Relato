using casa_relato.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace casa_relato.Controllers
{
    public class AliadosController : Controller
    {
        private readonly IConfiguration _configuration;

        public AliadosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int IdAliado { get; private set; }
        public string NombreAliado { get; private set; }
        public string DescripcionAliado { get; private set; }
        public string ImagenAliado { get; private set; }

        public ActionResult Index()
        {
            try
            {



                string Connection = _configuration.GetConnectionString("ConnectionStrings");
                var Aliados = new List<AliadosModel>();

                using (SqlConnection connections = new SqlConnection(Connection))
                {
                    string command = $@"Select * from Aliados";

                    using (SqlCommand cmd = new SqlCommand(command, connections))
                    {
                        connections.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                var aliados = new AliadosModel
                                {
                                    IdAliado = (int)reader["IdAliado"],
                                    NombreAliado = (string)reader["NombreAliado"],
                                    DescripcionAliado = (string)reader["DescripcionAliado"],
                                    ImagenAliado = (string)reader["ImagenAliado"]

                                };

                                Aliados.Add(aliados);

                            }

                        }
                    }

                }


                return View(Aliados);
            }

            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
