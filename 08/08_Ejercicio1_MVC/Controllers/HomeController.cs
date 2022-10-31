using Microsoft.AspNetCore.Mvc;

namespace _08_Ejercicio1_MVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index() { 
        
            return View();
        }



        public ActionResult Saludos(String nombre) {

            String saludo = "Hola " + nombre;

            ViewBag.Saludos = saludo;
            return View();
        }
    }
}