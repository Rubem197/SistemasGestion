using CRUD_Personas_ASP.Models;
using CRUD_Personas_ASP.Models.ViewModels;
using CRUD_Personas_BL;
using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;

namespace CRUD_Personas_ASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListadoPersona()
        {
            clsListadoPersonasVM awa = new clsListadoPersonasVM(); 
            return View((IEnumerable)(awa.ListadoCompletoPersonasMasDept));
        }

        public ActionResult ListadoDepartamento()
        { 
            return View((IEnumerable)(clsListadoDepartamentoBL.ListadoCompletoDepartamentos()));
        }
    }
}