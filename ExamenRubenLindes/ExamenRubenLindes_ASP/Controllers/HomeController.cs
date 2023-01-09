using ExamenRubenLindes_ASP.Models;
using ExamenRubenLindes_ASP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;

namespace ExamenRubenLindes_ASP.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListadoPersonasDept()
        {
            try
            {
                clsListadoPersonasDeptVM awa = new clsListadoPersonasDeptVM();
                return View(awa);
            }
            catch
            {
                return View("Error");
            }
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}