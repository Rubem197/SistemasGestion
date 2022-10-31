using _08_Ejercicio2_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _08_Ejercicio2_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Index(String nombre)
        {
            ViewBag.nombre = nombre;

            return View("Saludos");
        }

        public ActionResult Saludos()
        {

            return View();
        }
    }
}