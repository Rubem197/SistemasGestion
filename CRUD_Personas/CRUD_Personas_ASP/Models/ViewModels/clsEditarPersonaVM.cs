using CRUD_Personas_BL;
using CRUD_Personas_Entidades;

namespace CRUD_Personas_ASP.Models.ViewModels
{
    public class clsEditarPersonaVM
    {
        private clsPersonas persona;
        private List<clsDepartamentos> listadoCompletoDepartamentos;
        private clsDepartamentos departamentoMostrar;

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

        public clsDepartamentos DepartamentoMostrar
        {
            get { return departamentoMostrar; }
            set { departamentoMostrar = value; }
        }

        public clsEditarPersonaVM()
        {
            persona = new clsPersonas();
            listadoCompletoDepartamentos = clsListadoDepartamentoBL.ListadoCompletoDepartamentos();
            departamentoMostrar = new clsDepartamentos();
        }

        public static clsPersonas obtenerPersonaPorId(int id)
        {
            clsPersonas persona = new clsPersonaNombreDept();
            List<clsPersonas> lista = clsListadoPersonaBL.ListadoCompletoPersonas();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Id == id)
                {
                    persona = lista[i];
                }
            }

            return persona;
        }


        private clsDepartamentos obtenerDepartamentoSeleccionado()
        {
            for (int i = 0; i < listadoCompletoDepartamentos.Count; i++)
            {
                if (listadoCompletoDepartamentos[i].Id == persona.IdDepartamento + 1)
                {
                    departamentoMostrar.Id = i;
                }
            }
            return departamentoMostrar;
        }
    }
}
