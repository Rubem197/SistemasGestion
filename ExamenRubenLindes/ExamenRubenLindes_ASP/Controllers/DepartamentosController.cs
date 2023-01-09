using ExamenRubenLindes_ASP.Models.ViewModels;
using ExamenRubenLindes_BL;
using ExamenRubenLindes_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ExamenRubenLindes_ASP.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult borrar(int id)
        {
            clsBorrarDepartamentosVM VM = new clsBorrarDepartamentosVM(id);
            return View(VM);
        }
        /// <summary>
        /// En este command recibimos de nuevo la id y volvemos a crear la pagina de nuevo pero
        /// esta vez añadimos por ViewBag el string avisando que se han borrado las personas 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ActionName("borrar")]
        [HttpPost]
        public IActionResult borrarPost(int id)
        {
            clsBorrarDepartamentosVM VM = new clsBorrarDepartamentosVM(id);
            clsManejadoraPersonaBL.borrarPersonas(id);
            clsManejadoraDepartamentoBL.borrarDepartamento(id);
            ViewBag.personasBorradas = VM.PersonasBorradas;
            return View(VM);
        }
    }
}
