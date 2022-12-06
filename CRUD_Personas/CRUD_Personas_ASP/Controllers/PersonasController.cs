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
            clsPersonas persona = clsEditarPersonaVM.obtenerPersonaPorId(id);
            var vm = new clsEditarPersonaVM 
            { 
                Persona = clsEditarPersonaVM.obtenerPersonaPorId(id)
            };
            return View(persona);
        }

        [HttpPost]
        public IActionResult editarPersona(clsPersonas persona)
        {
            persona.IdDepartamento++;
            clsManejadoraPersonaBL.editarPersonas(persona);
            return RedirectToAction("ListadoPersona", "Home");
        }

        public IActionResult eliminarPersona(int id)
        {
            clsManejadoraPersonaBL.borrarPersonas(id);
            return RedirectToAction("ListadoPersona", "Home");
        }
    }
}
