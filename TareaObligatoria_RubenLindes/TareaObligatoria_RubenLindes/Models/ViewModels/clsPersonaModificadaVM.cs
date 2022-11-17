using DAL;
using Entidades;

namespace TareaObligatoria_RubenLindes.Models.ViewModels
{
    /// <summary>
    /// ViewModels que enviara a la vista Modificada la persona y el departamento de la persona 
    /// </summary>
    public class clsPersonaModificadaVM
    {
        public clsDepartamento departamento { get; set; }
        public clsPersona persona { get; set; }
        public clsPersonaModificadaVM()
        {
            departamento = clsManejadoraDepartamento.obtenerDepartamentoPorId(persona.IdDepartamento);

        }
    }
}
