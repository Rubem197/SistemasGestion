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
            clsEditarPersonaVM clsEditarPersonaVM = new clsEditarPersonaVM(id);
            return View(clsEditarPersonaVM);
        }

        [HttpPost]
        public IActionResult editarPersona(clsPersonas persona)
        {
            clsManejadoraPersonaBL.editarPersonas(persona);
            return RedirectToAction("ListadoPersona", "Home");
        }

        public IActionResult eliminarPersona(int id)
        {
            clsManejadoraPersonaBL.borrarPersonas(id);
            return RedirectToAction("ListadoPersona", "Home");
        }
        public IActionResult insertarPersona()
        {
            clsInsertarPersonaVM clsInsertarPersonaVM = new clsInsertarPersonaVM();
            return View(clsInsertarPersonaVM);
        }
        [HttpPost]
        public IActionResult insertarPersona(clsPersonas persona)
        {
            persona.IdDepartamento--;
            clsManejadoraPersonaBL.insertarPersonas(persona);
            return RedirectToAction("ListadoPersona", "Home");
        }
    }
}
