using Microsoft.AspNetCore.Mvc;

namespace CRUD_Personas_ASP.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
