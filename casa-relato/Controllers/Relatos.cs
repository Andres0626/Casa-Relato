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

        [HttpPost]
        public ActionResult InsertRelato(
            string titulo,
            string autor,
            string contenido)
        {
            try
            {

                string connectionString = _configuration.GetConnectionString("ConnectionStrings");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string commandText = @" INSERT INTO [dbo].[Relatos] ([Titulo], [Autor], [Contenido], [Vistas], [Me_Gusta])
                                            VALUES
                                            (@Titulo, @Autor, @Contenido, @Vistas, @Me_Gusta)";
                    int vistas = 0;
                    int megustas = 0;

                    using (SqlCommand cmd = new SqlCommand(commandText, connection))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", titulo);
                        cmd.Parameters.AddWithValue("@Autor", autor);
                        cmd.Parameters.AddWithValue("@Contenido", contenido);
                        cmd.Parameters.AddWithValue("@Vistas", vistas);
                        cmd.Parameters.AddWithValue("@Me_Gusta", megustas);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                return View("Error" + ex);

            }
        }

        [HttpPost]
        public ActionResult AgregarVista(
            int id_relato)
        {
            try
            {

                string connectionString = _configuration.GetConnectionString("ConnectionStrings");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string commandText = @"UPDATE [dbo].Relatos SET [Vistas] = [Vistas] + 1 WHERE IdRelato = @IdRelato";

                    using (SqlCommand cmd = new SqlCommand(commandText, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdRelato", id_relato);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                return View("Error" + ex);

            }
        }
    }
}
