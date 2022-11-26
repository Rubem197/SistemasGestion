using CRUD_Personas_BL;
using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD11_Ejercicio1_Maui.ViewModels.Utilidades;

namespace CRUD_Personas_MAUI.ViewModels
{
    public class InsertarPersonaVM : INotifyPropertyChanged
    {
          
        #region Atributos

        private clsPersonas personaSeleccionada;
        private List<clsDepartamentos> listadoDepartamentos;
        private DelegateCommand guardarCommand;
        public event PropertyChangedEventHandler PropertyChanged;


        #endregion

        #region Propiedades
        public clsPersonas PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                personaSeleccionada = value;
                guardarCommand.RaiseCanExecuteChanged();

            }
        }
        public List<clsDepartamentos> ListadoDepartamentos
        {
            get { return listadoDepartamentos; }
            set { listadoDepartamentos = value; }
        }

        public DelegateCommand GuardarCommand
        {
            get { return guardarCommand; }
            set { guardarCommand = value; }
        }

        #endregion

        #region Constructor
        public InsertarPersonaVM()
        {
            personaSeleccionada = new clsPersonas();
            listadoDepartamentos = clsListadoDepartamentoDAL.ListadoCompletoDepartamentos();
            guardarCommand = new DelegateCommand(guardarPersonaCommand_Executed, guardarPersonaCommand_CanExecute);
        }
        #endregion


        #region Comandos

        private bool guardarPersonaCommand_CanExecute()
        {
            bool lanzarExecuted = true;
            return lanzarExecuted;
        }

        private void guardarPersonaCommand_Executed()
        {
            clsManejadoraPersonaBL.insertarPersonas(PersonaSeleccionada);

        }

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
