using Microsoft.AspNetCore.Mvc;

namespace _06_HolaMundo_MVC_UI.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "Hola mundo desde el controlador";
        }
        public String Salva()
        {
            return "Hola Salva desde el controlador";
        }

        public ViewResult ListadoProductos() { 
        

            return View();
        }

    }
}
