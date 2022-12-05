using CRUD_Personas_BL;
using CRUD_Personas_Entidades;

namespace CRUD_Personas_ASP.Models.ViewModels
{
    public class clsListadoPersonasVM
    {
        private static IEnumerable<clsPersonas> listadoCompletoPersonas;

        public static IEnumerable<clsPersonas> ListadoCompletoPersonas
        {
            get { return clsListadoPersonaBL.ListadoCompletoPersonas();}
            set { listadoCompletoPersonas = value; }
        }



        public clsListadoPersonasVM()
        {

        }
    }
}
