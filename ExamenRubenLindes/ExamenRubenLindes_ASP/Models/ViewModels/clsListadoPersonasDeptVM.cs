using ExamenRubenLindes_BL;
using ExamenRubenLindes_Entidades;

namespace ExamenRubenLindes_ASP.Models.ViewModels
{
    public class clsListadoPersonasDeptVM
    {
        private List<clsPersona> listadoCompletoPersonas;
        private List<clsDepartamento> listadoCompletoDept;


        public List<clsPersona> ListadoCompletoPersonas
        {
            get { return listadoCompletoPersonas; }
            set { listadoCompletoPersonas = value; }
        }

        public List<clsDepartamento> ListadoCompletoDept
        {
            get { return listadoCompletoDept; }
            set { ListadoCompletoDept = value; }
        }

        public clsListadoPersonasDeptVM()
        {
            listadoCompletoPersonas = clsListadoPersonaBL.ListadoCompletoPersonas();
            listadoCompletoDept = clsListadoDepartamentoBL.ListadoCompletoDepartamentos();
        }
    }
}

