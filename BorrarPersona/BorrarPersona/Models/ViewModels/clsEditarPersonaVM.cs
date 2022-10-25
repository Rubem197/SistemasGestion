using DAL;
using Entidades;

namespace EditarPersona_UI_MVC.Models.ViewModels
{
    public class clsEditarPersonaVM
    {
        public List<clsDepartamento> listadoCompletoDepartamento { get; }
        public clsPersona persona { get; set; }

        public clsEditarPersonaVM()
        {
            this.persona = clsManejadoraPersonaDAL.ObternerPersonaPorId(2);
            this.listadoCompletoDepartamento = clsListadoDepartamentosDAL.obtenerListadoCompletoDepartamento();
        }
    }
}
