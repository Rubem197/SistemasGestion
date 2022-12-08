using CRUD_Personas_ASP.Models.ViewModels;
using CRUD_Personas_BL;
using CRUD_Personas_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Personas_ASP.Controllers
{
    public class departamentoController : Controller
    {
        public IActionResult editarDepartamento(int id)
        {
            
            return View(clsEditarDepartamentoVM.obtenerDepartamentoPorId(id));
        }

        [HttpPost]
        public IActionResult editarDepartamento(clsDepartamentos departamento)
        {
            clsManejadoraDepartamentoBL.editarDepartamento(departamento);
            return RedirectToAction("ListadoDepartamento", "Home");
        }

        public IActionResult insertarDepartamento()
        {
            clsDepartamentos departamentos = new clsDepartamentos();
            return View(departamentos);
        }

        [HttpPost]
        public IActionResult insertarDepartamento(clsDepartamentos departamento)
        {
            clsManejadoraDepartamentoBL.insertarDepartamento(departamento);
            return RedirectToAction("ListadoDepartamento", "Home");
        }

        public IActionResult borrarDepartamento(int id)
        {
            clsManejadoraDepartamentoBL.borrarDepartamento(id);
            return RedirectToAction("ListadoDepartamento", "Home");
        }

    }
}
