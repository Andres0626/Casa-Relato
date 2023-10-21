using casa_relato.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace casa_relato.Controllers
{
    public class Relatos : Controller
    {
        private readonly IConfiguration _configuration;

        public Relatos(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            try
            {



                string Connection = _configuration.GetConnectionString("ConnectionStrings");
                var Relatos = new List<RelatosModel>();

                using (SqlConnection connections = new SqlConnection(Connection))
                {
                    string command = $@"Select * from Relatos";

                    using (SqlCommand cmd = new SqlCommand(command, connections))
                    {
                        connections.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                var relatos = new RelatosModel
                                {
                                    IdRelato = (int)reader["IdRelato"],
                                    Titulo = (string)reader["Titulo"],
                                    Autor = (string)reader["Autor"],
                                    Contenido = (string)reader["Contenido"],
                                    Vistas = (int)reader["Vistas"],
                                    Megusta = (int)reader["Me_Gusta"]

                                };

                                Relatos.Add(relatos);

                            }

                        }
                    }

                }


                return View(Relatos);
            }

            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
