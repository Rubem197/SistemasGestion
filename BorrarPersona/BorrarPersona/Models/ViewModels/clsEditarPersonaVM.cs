using Entidades;

namespace EditarPersona_UI_MVC.Models.ViewModels
{
    public class clsEditarPersonaVM
    {
        public List<clsDepartamento> listadoCompletoDepartamento { get; }
        public clsPersona persona { get; set; }
    }
}
