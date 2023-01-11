using Microsoft.AspNetCore.SignalR.Client;
using SignalRChatMaui.ViewModels.Utilidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChatMaui.ViewModels
{
    public class chatVM : clsVMBase
    {
        #region Atributos
        private readonly HubConnection conexion;
        private List<string> listaMensajes;
        private string mensaje;
        private DelegateCommand enviarMensajeCommand;
        #endregion
        #region Propiedades
        public List<string> ListaMensajes
        {
            get { return listaMensajes; }
            set { listaMensajes = value; }
        }
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public DelegateCommand EnviarMensajeCommand
        {
            get { return enviarMensajeCommand; }
            set { enviarMensajeCommand = value; }
        }
        #endregion
        #region Constructor
        
        public chatVM()
        {
            conexion = new HubConnectionBuilder()
                .WithUrl("https://signalrchatss.azurewebsites.net/ChatHub")
                .Build();
            enviarMensajeCommand = new DelegateCommand(enviarMensaje_Execute, enviarMensaje_CanExecute);
        }

        #endregion

        #region Metodos


        private bool enviarMensaje_CanExecute()
        {
            throw new NotImplementedException();
        }

        private void enviarMensaje_Execute()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
