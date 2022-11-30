using CRUD_Personas_BL;
using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;
using CRUD_Personas_MAUI.Views;
using System.ComponentModel;
using System.Web;
using UD11_Ejercicio1_Maui.ViewModels.Utilidades;

namespace CRUD_Personas_MAUI.ViewModels
{
    [QueryProperty(nameof(PersonaSeleccionada), "personaSeleccionada")]
    public class EditarPersonaVM : INotifyPropertyChanged
    {
        #region Atributos

        private clsPersonas personaSeleccionada;
        private List<clsDepartamentos> listadoDepartamentos;
        private clsDepartamentos departamentoSeleccionado;
        private clsDepartamentos departamentoMostrar;
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
                NotifyPropertyChanged();
                guardarCommand.RaiseCanExecuteChanged();
                igualarDeptList();
            }
        }
        public List<clsDepartamentos> ListadoDepartamentos
        {
            get { return listadoDepartamentos; }
            set { listadoDepartamentos = value; }
        }
        public clsDepartamentos DepartamentoSeleccionado
        {
            get { return departamentoSeleccionado; }
            set 
            { 
                departamentoSeleccionado = value;
                
            }
        }
        public clsDepartamentos DepartamentoMostrar
        {
            get { return departamentoMostrar; }
            set
            {
                departamentoMostrar = value;
            }
        }
        public DelegateCommand GuardarCommand
        {
            get { return guardarCommand; }
            set { guardarCommand = value; }
        }

        #endregion

        #region Constructor
        public EditarPersonaVM()
        {
            departamentoMostrar = new clsDepartamentos();
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
            personaSeleccionada.IdDepartamento = departamentoSeleccionado.Id;
            clsManejadoraPersonaBL.editarPersonas(PersonaSeleccionada);
            
        }
        /// <summary>
        /// Metodo que cuando el departamento es igual a un departamento de una lista
        /// le asigna al departamentoMostrar la posicion de la lista.
        /// </summary>
        private void igualarDeptList()
        {
            for (int i=0;  i< listadoDepartamentos.Count; i++)
            {
                if (listadoDepartamentos[i].Id == personaSeleccionada.IdDepartamento+1)
                {
                    departamentoMostrar.Id = i;
                }
            }
            NotifyPropertyChanged("DepartamentoMostrar");
        }

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
