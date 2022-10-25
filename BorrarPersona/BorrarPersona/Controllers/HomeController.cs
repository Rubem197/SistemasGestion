using EditarPersona_UI_MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EditarPersona_UI_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Editor()
        {

            clsEditarPersonaVM editarPersonaVM = new clsEditarPersonaVM();

            return View();
        }
    }
}
