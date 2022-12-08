using CRUD_Personas_BL;
using CRUD_Personas_Entidades;

namespace CRUD_Personas_ASP.Models.ViewModels
{
    public class clsInsertarPersonaVM
    {
        private clsPersonas persona;
        private List<clsDepartamentos> listadoCompletoDepartamentos;

        public clsPersonas Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        public List<clsDepartamentos> ListadoCompletoDepartamentos
        {
            get { return listadoCompletoDepartamentos; }
            set { listadoCompletoDepartamentos = value; }
        }

        public clsInsertarPersonaVM()
        {
            persona = new clsPersonas();
            listadoCompletoDepartamentos = clsListadoDepartamentoBL.ListadoCompletoDepartamentos();
        }
    }
}
