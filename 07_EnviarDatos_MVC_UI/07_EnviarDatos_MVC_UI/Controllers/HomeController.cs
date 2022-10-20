using _07_DAL;
using _07_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace _07_EnviarDatos_MVC_UI.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Aqui se pasa a la vista el momento del dia a traves de ViewData y enviara un mensaje segun el momento del dia
        /// Enviara la fecha y hora a la vista por viewBag
        /// Inicializacion de la clsPersona y se rellenan los datos de una persona y lo returna a la vista por model
        /// Enviar a la vista por ViewData el listado de persona
        /// Precondiciones: 
        /// Postcondiciones: Se entregara un ViewData del listado de persona (o de el estado del dia), ViewBag de la fecha actual y retornar por model una persona de clsPersona
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            /**
            if (DateTime.Now.Hour < 12)
            {
                ViewData["estadoDia"] = "Buenos dias";
            }
            else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 20)
            {
                ViewData["estadoDia"] = "Buenas tardes";
            }
            else 
            {
                ViewData["estadoDia"] = "Buenas noches";
            }
            */

            ViewBag.fecha = DateTime.Now.ToString();


            clsPersona persona1 = new clsPersona();

            persona1.idPersona = 1;
            persona1.nombre = "Ruben";
            persona1.apellidos = "Lindes";
            persona1.direccion = "Mi calle";
            persona1.telefono = 634735417;


            ViewData["ListadoPersonas"] = clsListadoPersonaDAL.obtenerListadoCompletoPersonas();

            return View(persona1);
        }

    }
}