using DAL;
using Entidades;

namespace TareaObligatoria_RubenLindes.Models.ViewModels
{
    public class clsEditarPersonaDepartamentoVM
    {
        public List<clsDepartamento> listadoDepartamento { get; }
        public clsPersona persona { get; set; }

        public clsEditarPersonaDepartamentoVM()
        {
            listadoDepartamento = clsListaDepartamento.listadoDepartamento();
            persona = new clsPersona();
        }
    }
}
