using CRUD_Personas_BL;
using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;
using System.Collections.ObjectModel;
using UD11_Ejercicio1_Maui.ViewModels.Utilidades;

namespace CRUD_Personas_MAUI.ViewModels
{
    public class clsListadoPersonasVM
    {
        #region Atributos
        private ObservableCollection<clsPersonas> listadoCompletoPersonas;
        private ObservableCollection<clsPersonas> backupListadoCompletoPersonas;
        private clsPersonas personaSeleccionada;
        private String busquedaPersona;
        private DelegateCommand buscarPersona;
        private DelegateCommand borrarCommand;
        private DelegateCommand editarCommand;
        private DelegateCommand insertarCommand;
        #endregion

        #region Propiedades
        public ObservableCollection<clsPersonas> ListadoCompletoPersonas
        {
            get
            {
                return listadoCompletoPersonas;
            }
        }
        public clsPersonas PersonaSeleccionada 
        {
            get { return personaSeleccionada; }
            set { personaSeleccionada = value; borrarCommand.RaiseCanExecuteChanged(); }
        }
        public DelegateCommand BorrarPersona
        {
            get { return borrarCommand; }
            set { borrarCommand = value; }
        }
        #endregion

        #region Constructores

        public clsListadoPersonasVM()
        {
            listadoCompletoPersonas = new ObservableCollection<clsPersonas>(clsListadoPersonaBL.ListadoCompletoPersonas());
            BorrarPersona = new DelegateCommand(borrarPersonaCommand_Executed, borrarPersonaCommand_CanExecute);
        }

        #endregion

        #region Comandos

        private bool borrarPersonaCommand_CanExecute() {
            bool lanzarExecuted = true;

            if (PersonaSeleccionada == null) { 
            
                lanzarExecuted = false;
            }

            return lanzarExecuted;
        }

        private void borrarPersonaCommand_Executed() { 
        
            for (int i = 0; i < listadoCompletoPersonas.Count; i++)
            {
                if (PersonaSeleccionada.Equals(listadoCompletoPersonas[i])) 
                {
                    listadoCompletoPersonas.RemoveAt(i);
                    clsManejadoraPersonaDAL.borrarPersonas(personaSeleccionada.Id);
                }
            }
        }

        #endregion
    }
}
