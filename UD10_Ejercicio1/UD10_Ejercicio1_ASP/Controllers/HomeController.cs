using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using UD10_Ejercicio1_ASP.Models;
using UD10_Ejercicio1_ASP.Models.DAL;

namespace UD10_Ejercicio1_ASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost()
        {
            SqlConnection miConexion = new SqlConnection();

            try

            {

                miConexion.ConnectionString
                = "server=rlindes.database.windows.net;database=rubenDB;uid=fernando;pwd=Mandaloriano69;";
                miConexion.Open();

                ViewBag.estadoConexion = miConexion.State;

            }
            catch (Exception e) {

                //todo Mandar una pagina de error
            }
            finally
            {
                miConexion.Close();
            }
           
            return View();
        }

        public ActionResult ListadoPersona()
        {
            
            return View(ObtenerListadoPersonaVM.ObtenerPersonas());
        }
    }
}