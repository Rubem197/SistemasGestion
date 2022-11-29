using CRUD_Personas_BL;
using CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD11_Ejercicio1_Maui.ViewModels.Utilidades;

namespace CRUD_Personas_MAUI.ViewModels
{
    public class clsListadoDepartamentosVM : INotifyPropertyChanged
    {

        #region Atributos
        private ObservableCollection<clsDepartamentos> listadoCompletoDept;
        private ObservableCollection<clsDepartamentos> backupListadoCompletoDept;
        private clsDepartamentos deptSeleccionado;
        private string busquedaDept;
        private DelegateCommand buscarDept;
        private DelegateCommand borrarCommand;
        private DelegateCommand editarCommand;
        private DelegateCommand insertarCommand;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Propiedades
        public ObservableCollection<clsDepartamentos> ListadoCompletoDept
        {
            get { return listadoCompletoDept; }
            set { listadoCompletoDept = value; }
        }
        public clsDepartamentos DeptSeleccionado
        {
            get { return deptSeleccionado; }
            set 
            { 
                deptSeleccionado = value;
                editarCommand.RaiseCanExecuteChanged();
                borrarCommand.RaiseCanExecuteChanged();
            }
        }
        public string BusquedaDept
        {
            get { return busquedaDept; }
            set
            {
                busquedaDept = value;
                BuscarDept.RaiseCanExecuteChanged();

                if (busquedaDept == "")
                {
                    listadoCompletoDept.Clear();
                    for (int i = 0; i < backupListadoCompletoDept.Count; i++)
                    {
                        listadoCompletoDept.Add(backupListadoCompletoDept[i]);
                    }
                }
            }
        }
        public DelegateCommand BuscarDept
        {
            get { return buscarDept; }
            set { buscarDept = value; }
        }
        public DelegateCommand BorrarCommand
        {
            get { return borrarCommand; }
            set { borrarCommand = value; }
        }
        public DelegateCommand EditarCommand
        {
            get { return editarCommand; }
            set{ editarCommand = value; }
        }
        public DelegateCommand InsertarCommand
        {
            get { return insertarCommand; }
            set { insertarCommand = value; }
        }


        #endregion


        #region Constructor
        public clsListadoDepartamentosVM()
        {
            listadoCompletoDept = new ObservableCollection<clsDepartamentos>(clsListadoDepartamentoBL.ListadoCompletoDepartamentos());
            backupListadoCompletoDept = new ObservableCollection<clsDepartamentos>(clsListadoDepartamentoBL.ListadoCompletoDepartamentos());
            BuscarDept = new DelegateCommand(buscarDeptCommand_Executed, buscarDeptCommand_CanExecute);
            BorrarCommand = new DelegateCommand(borrarDeptCommand_Executed, borrarDeptCommand_CanExecute);
            editarCommand = new DelegateCommand(editarDeptCommand_Executed, editarDeptCommand_CanExecute);
            insertarCommand = new DelegateCommand(insertarDeptCommand_Executed, insertarDeptCommand_CanExecute);
        }


        #endregion

        #region Comandos
        private bool buscarDeptCommand_CanExecute()
        {
            bool lanzarExecuted = false;
            if (BusquedaDept != "")
            {
                lanzarExecuted = true;
            }
            return lanzarExecuted;
        }

        private void buscarDeptCommand_Executed()
        {
            for (int i = 0; i < ListadoCompletoDept.Count; i++)
            {
                if (!ListadoCompletoDept[i].Nombre.Contains(BusquedaDept))
                {
                    ListadoCompletoDept.RemoveAt(i);
                    i--;
                }
            }
        }


        private bool borrarDeptCommand_CanExecute()
        {
            bool lanzarExecuted = true;

            if (DeptSeleccionado == null)
            {

                lanzarExecuted = false;
            }

            return lanzarExecuted;
        }

        private void borrarDeptCommand_Executed()
        {
            for (int i = 0; i < listadoCompletoDept.Count; i++)
            {
                if (DeptSeleccionado.Equals(listadoCompletoDept[i]))
                {
                    listadoCompletoDept.RemoveAt(i);
                    backupListadoCompletoDept.RemoveAt(i);
                    clsManejadoraDepartamentoBL.borrarDepartamento(deptSeleccionado.Id);
                }
            }
        }

        private bool editarDeptCommand_CanExecute()
        {
            bool lanzarExecuted = true;

            if (DeptSeleccionado == null)
            {
                lanzarExecuted = false;
            }

            return lanzarExecuted;
        }
        private async void editarDeptCommand_Executed()
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "deptSeleccionado", DeptSeleccionado }
            };
            await Shell.Current.GoToAsync($"EditarDepartamento", navigationParameter);
        }

        private bool insertarDeptCommand_CanExecute()
        {
            return true;
        }
        private async void insertarDeptCommand_Executed()
        {
            await Shell.Current.GoToAsync($"InsertarDepartamento");
        }
        public void actualizarLista()
        {
            listadoCompletoDept = new ObservableCollection<clsDepartamentos>(clsListadoDepartamentoBL.ListadoCompletoDepartamentos());
            NotifyPropertyChanged("ListadoCompletoDept");
        }

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
    }
}
