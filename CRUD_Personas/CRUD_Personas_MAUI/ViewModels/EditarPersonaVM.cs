using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;
using CRUD_Personas_MAUI.Views;
using System.ComponentModel;
using System.Web;

namespace CRUD_Personas_MAUI.ViewModels
{
    public class EditarPersonaVM : IQueryAttributable
    {
        #region Atributos

        private clsPersonas personaSeleccionada;
        private List<clsDepartamentos> listadoDepartamentos;


        #endregion

        #region Propiedades
        public clsPersonas PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { personaSeleccionada = value; }
        }
        public List<clsDepartamentos> ListadoDepartamentos
        {
            get { return listadoDepartamentos; }
            set { listadoDepartamentos = value;}
        }
        #endregion
        public EditarPersonaVM()
        {
            
            listadoDepartamentos = clsListadoDepartamentoDAL.ListadoCompletoDepartamentos();
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            personaSeleccionada = query["clsPersonas"] as clsPersonas;
        }

    }
}
