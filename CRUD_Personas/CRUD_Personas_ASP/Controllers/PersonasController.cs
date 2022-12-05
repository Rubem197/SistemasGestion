using CRUD_Personas_ASP.Models;
using CRUD_Personas_ASP.Models.ViewModels;
using CRUD_Personas_BL;
using CRUD_Personas_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Personas_ASP.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult editarPersona(int id)
        {
            return View(clsEditarPersonaVM.obtenerPersonaPorId(id));
        }

        [HttpPost]
        public IActionResult editarPersona(clsPersonas persona)
        {
            clsManejadoraPersonaBL.editarPersonas(persona);
            return View();
        }
    }
}
