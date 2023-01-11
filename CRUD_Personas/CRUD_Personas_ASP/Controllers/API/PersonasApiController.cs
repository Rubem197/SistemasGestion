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
        public clsPersonas Get(int id)
        {
            return clsManejadoraPersonaBL.obtenerPersonaPorId(id);
        }

        // POST api/<PersonasApiController>
        [HttpPost]
        public int Post([FromBody] clsPersonas persona)
        {
            try
            {
                return clsManejadoraPersonaBL.insertarPersonas(persona);
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        // PUT api/<PersonasApiController>/5
        [HttpPut("{id}")]
        public int Put([FromBody] clsPersonas persona)
        {
            try
            {
                return clsManejadoraPersonaBL.editarPersonas(persona);
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        // DELETE api/<PersonasApiController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return clsManejadoraPersonaBL.borrarPersonas(id);
        }
    }
}
