using CRUD_Personas_ASP.Models.ViewModels;
using CRUD_Personas_BL;
using CRUD_Personas_Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD_Personas_ASP.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasApiController : ControllerBase
    {
        // GET: api/<PersonasApiController>
        [HttpGet]
        public IEnumerable<clsPersonas> Get()
        {
            return clsListadoPersonaBL.ListadoCompletoPersonas();
        }

        // GET api/<PersonasApiController>/5
        [HttpGet("{id}")]
        public clsEditarPersonaVM Get(int id)
        {
            clsEditarPersonaVM clsEditarPersonaVM = new clsEditarPersonaVM(id);
            return clsEditarPersonaVM;
        }

        // POST api/<PersonasApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonasApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonasApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
