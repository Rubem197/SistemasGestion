using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CRUD_Personas_BL;
using CRUD_Personas_Entidades;
using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;
using System.ComponentModel;
using UD11_Ejercicio1_Maui.ViewModels.Utilidades;

namespace CRUD_Personas_MAUI.ViewModels
{
    public class clsListadoPersonasVM : INotifyPropertyChanged
    {


        #region Atributos
        private ObservableCollection<clsPersonas> listadoCompletoPersonas;
        private ObservableCollection<clsPersonas> backupListadoCompletoPersonas;
        private clsPersonas personaSeleccionada;
        private string busquedaPersona;
        private DelegateCommand buscarPersona;
        private DelegateCommand borrarCommand;
        private DelegateCommand editarCommand;
        private DelegateCommand insertarCommand;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Propiedades
        public ObservableCollection<clsPersonas> ListadoCompletoPersonas
        {
            get
            {
                return listadoCompletoPersonas;
            }
            set { listadoCompletoPersonas = value; }
        }
        public clsPersonas PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                personaSeleccionada = value;
                borrarCommand.RaiseCanExecuteChanged();
                editarCommand.RaiseCanExecuteChanged();
            }
        }

        public string BusquedaPersona
        {
            get { return busquedaPersona; }
            set
            {
                busquedaPersona = value;
                BuscarPersona.RaiseCanExecuteChanged();

                if (busquedaPersona == "")
                {
                    listadoCompletoPersonas.Clear();
                    for (int i = 0; i < backupListadoCompletoPersonas.Count; i++)
                    {
                        listadoCompletoPersonas.Add(backupListadoCompletoPersonas[i]);
                    }
                }
            }
        }

        public DelegateCommand BuscarPersona
        {
            get { return buscarPersona; }
            set { buscarPersona = value; }
        }
        public DelegateCommand BorrarPersona
        {
            get { return borrarCommand; }
            set { borrarCommand = value; }
        }

        public DelegateCommand EditarPersona
        {
            get { return editarCommand; }
            set { editarCommand = value; }
        }

        public DelegateCommand InsertarPersona
        {
            get { return insertarCommand; }
            set { insertarCommand = value; }
        }

        #endregion

        #region Constructores

        public clsListadoPersonasVM()
        {
            try
            {
                backupListadoCompletoPersonas = new ObservableCollection<clsPersonas>(clsListadoPersonaBL.ListadoCompletoPersonas());
            }
            catch (SqlException)
            {
                var toast = Toast.Make("La base de datos no esta disponible", ToastDuration.Long).Show();
            }
            BuscarPersona = new DelegateCommand(buscarPersonaCommand_Executed, buscarPersonaCommand_CanExecute);
            BorrarPersona = new DelegateCommand(borrarPersonaCommand_Executed, borrarPersonaCommand_CanExecute);
            editarCommand = new DelegateCommand(editarPersonaCommand_Executed, editarPersonaCommand_CanExecute);
            insertarCommand = new DelegateCommand(insertarPersonaCommand_Executed, insertarPersonaCommand_CanExecute);
        }



        #endregion

        #region Comandos

        private bool buscarPersonaCommand_CanExecute()
        {
            bool lanzarExecuted = false;
            if (BusquedaPersona != "")
            {
                lanzarExecuted = true;
            }
            return lanzarExecuted;
        }
        /// <summary>
        /// Metodo que compara el contenido de los nombres y apellidos
        /// de la lista de personas y si es igual a lo buscado.
        /// </summary>
        private void buscarPersonaCommand_Executed()
        {

            for (int i = 0; i < ListadoCompletoPersonas.Count; i++)
            {
                if (!ListadoCompletoPersonas[i].Nombre.Contains(BusquedaPersona) && !ListadoCompletoPersonas[i].Apellidos.Contains(BusquedaPersona))
                {
                    ListadoCompletoPersonas.RemoveAt(i);
                    i--;
                }
            }
        }

        private bool borrarPersonaCommand_CanExecute()
        {
            bool lanzarExecuted = true;

            if (PersonaSeleccionada == null)
            {

                lanzarExecuted = false;
            }

            return lanzarExecuted;
        }
        /// <summary>
        /// Metodo que borra la persona seleccionada del listado 
        /// y que llama a la base de datos para borrarla de alli.
        /// </summary>
        private void borrarPersonaCommand_Executed()
        {

            for (int i = 0; i < listadoCompletoPersonas.Count; i++)
            {
                if (PersonaSeleccionada.Equals(listadoCompletoPersonas[i]))
                {
                    listadoCompletoPersonas.RemoveAt(i);
                    backupListadoCompletoPersonas.RemoveAt(i);
                    try
                    {
                        clsManejadoraPersonaBL.borrarPersonas(personaSeleccionada.Id);
                    }
                    catch (SqlException)
                    {
                        var toast = Toast.Make("La base de datos no esta disponible", ToastDuration.Long).Show();
                    }
                }
            }
        }
        private bool editarPersonaCommand_CanExecute()
        {
            bool lanzarExecuted = true;

            if (PersonaSeleccionada == null)
            {
                lanzarExecuted = false;
            }

            return lanzarExecuted;
        }
        /// <summary>
        /// Metodo que guarda en un diccionario la persona seleccionada 
        /// y te envia a la vista EditarPersona con la personaSeleccionada
        /// </summary>
        private async void editarPersonaCommand_Executed()
        {

            var navigationParameter = new Dictionary<string, object>
            {
                { "personaSeleccionada", PersonaSeleccionada }
            };
            await Shell.Current.GoToAsync($"EditarPersona", navigationParameter);
        }
        private bool insertarPersonaCommand_CanExecute()
        {
            return true;
        }

        private async void insertarPersonaCommand_Executed()
        {
            await Shell.Current.GoToAsync($"InsertarPersona");
        }

        public void actualizarLista()
        {
            try
            {
                listadoCompletoPersonas = new ObservableCollection<clsPersonas>(clsListadoPersonaBL.ListadoCompletoPersonas());
            }
            catch (SqlException)
            {
                var toast = Toast.Make("La base de datos no esta disponible", ToastDuration.Long).Show();
            }
            NotifyPropertyChanged("ListadoCompletoPersonas");
        }

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
