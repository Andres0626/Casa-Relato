using casa_relato.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace casa_relato.Controllers
{
    public class Reseñas : Controller
    {

             private readonly IConfiguration _configuration;

        public Reseñas(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            try
            {



                string Connection = _configuration.GetConnectionString("ConnectionStrings");
                var Reseñas = new List<ReseñasModel>();

                using (SqlConnection connections = new SqlConnection(Connection))
                {
                    string command = $@"Select * from Comentarios";

                    using (SqlCommand cmd = new SqlCommand(command, connections))
                    {
                        connections.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                var reseñas = new ReseñasModel
                                {
                                    ID = (int)reader["IdComentario"],
                                    UserName = (string)reader["UserName"],
                                    Comentario = (string)reader["Comentario"]
                                };

                                Reseñas.Add(reseñas);

                            }

                        }
                    }

                }


                return View(Reseñas);
            }

            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult InsertComment(string username, string comment)
        {
            try
            {

                string connectionString = _configuration.GetConnectionString("ConnectionStrings");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string commandText = @"
            INSERT INTO [dbo].[Comentarios]
            ([UserName]
            ,[Comentario])
            VALUES
            (@Username, @Comment)";

                    using (SqlCommand cmd = new SqlCommand(commandText, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Comment", comment);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return RedirectToAction("Index");

            } catch (Exception ex)
            {

                return View("Error");

            }
        }

    }
}
