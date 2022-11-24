using CRUD_Personas_ASP.Models;
using CRUD_Personas_BL;
using CRUD_Personas_DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;

namespace CRUD_Personas_ASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ListadoPersona()
        {
            return View((IEnumerable)(clsListadoPersonaBL.ListadoCompletoPersonas()));
        }

        public ActionResult ListadoDepartamento()
        {
            return View((IEnumerable)(clsListadoDepartamentoBL.ListadoCompletoDepartamentos()));
        }
    }
}