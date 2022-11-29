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
    [QueryProperty(nameof(clsDepartamentos), "deptSeleccionado")]
    public class EditarDeptVM : IQueryAttributable, INotifyPropertyChanged
    {
        #region Atributos

        private clsDepartamentos deptSeleccionado;
        private DelegateCommand guardarCommand;
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Propiedades
        public clsDepartamentos DeptSeleccionado
        {
            get { return deptSeleccionado; }
            set
            {
                deptSeleccionado = value;
                guardarCommand.RaiseCanExecuteChanged();

            }
        }

        public DelegateCommand GuardarCommand
        {
            get { return guardarCommand; }
            set { guardarCommand = value; }
        }

        #endregion

        #region Constructor
        public EditarDeptVM()
        {
            guardarCommand = new DelegateCommand(guardarDeptCommand_Executed, guardarDeptCommand_CanExecute);
        }
        #endregion


        #region Comandos
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            deptSeleccionado = query["deptSeleccionado"] as clsDepartamentos;
            NotifyPropertyChanged("DeptSeleccionado");
        }

        private bool guardarDeptCommand_CanExecute()
        {
            return true;
        }

        private void guardarDeptCommand_Executed()
        {
            clsManejadoraDepartamentoBL.editarDepartamento(DeptSeleccionado);

        }

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
