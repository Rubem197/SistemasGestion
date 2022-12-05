using DAL;
using Entidades;
using juegoBabyJoda_Maui.ViewModels.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoBabyJoda_Maui.ViewModels
{
    public class clsTableroVM : INotifyPropertyChanged
    {
        #region Atributos
        ObservableCollection<clsCartas> listaCartas;
        ObservableCollection<clsCartas> tablero;
        clsCartas cartaSeleccionada;
        private DelegateCommand pulsarCarta;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Propiedades
        public ObservableCollection<clsCartas> ListaCartas
        {
            get
            {
                return listaCartas;
            }
            set
            {
                listaCartas = value;
            }
        }
        public ObservableCollection<clsCartas> Tablero
        {
            get { return tablero; }
            set { tablero = value;  }
        }
        public clsCartas CartaSeleccionada
        {
            get { return cartaSeleccionada; }
            set
            {
                cartaSeleccionada = value;
                pulsarCarta.RaiseCanExecuteChanged();
                

            }
        }
        public DelegateCommand PulsarCarta
        {
            get { return pulsarCarta; }
            set 
            { 
                pulsarCarta = value;
            }

        }
        #endregion

        #region Constructor
        public clsTableroVM()
        {
            listaCartas = new ObservableCollection<clsCartas>(clsListadoCartasDAL.ListadoCompletoCartas());
            tablero = new ObservableCollection<clsCartas>();
            cartaSeleccionada = new clsCartas();
            pulsarCarta = new DelegateCommand(pulsarCartaCommand_Executed, pulsarCartaCommand_CanExecute);
            generarTablero();

        }

        #endregion

        #region Comandos

        /// <summary>
        /// Metodo que genera un tablero pero no aleatorio con 4 aliados y 5 enemigos
        /// postcondicion: Devuelve un ObservableCollactions de clsCartas
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<clsCartas> generarTableroNoAleatorio()
        {
            ObservableCollection<clsCartas> tableroNoAleatorio = new ObservableCollection<clsCartas>();

            tableroNoAleatorio.Add(listaCartas[0]);
            tableroNoAleatorio.Add(listaCartas[0]);
            tableroNoAleatorio.Add(listaCartas[1]);
            tableroNoAleatorio.Add(listaCartas[1]);
            tableroNoAleatorio.Add(listaCartas[2]);
            tableroNoAleatorio.Add(listaCartas[3]);
            tableroNoAleatorio.Add(listaCartas[4]);
            tableroNoAleatorio.Add(listaCartas[5]);
            tableroNoAleatorio.Add(listaCartas[6]);

            return tableroNoAleatorio;
        }
        /// <summary>
        /// Metodo que genera el tablero aleatorio, para ello
        /// generamos 9 campos vacios de tablero y luego añadimos
        /// en posiciones aleatorias siempre distintas las cartas
        /// </summary>
        private void generarTablero()
        {
            Random aleatorio = new Random();
            int numeroAleatorio;
            ObservableCollection<clsCartas> tableroNoAleatorio = generarTableroNoAleatorio();
            for (int i = 0; i < 9; i++)
            {
                tablero.Add(new clsCartas());
            }

            for (int i = 0; i < 9; i++)
            {

                numeroAleatorio = aleatorio.Next(0, 9);

                while (tablero[numeroAleatorio].Nombre != null)
                {
                    numeroAleatorio = aleatorio.Next(0, 9);
                }
                tablero[numeroAleatorio].Id = tableroNoAleatorio[i].Id;
                tablero[numeroAleatorio].Nombre = tableroNoAleatorio[i].Nombre;
                tablero[numeroAleatorio].Imagen = tableroNoAleatorio[i].Imagen;
                tablero[numeroAleatorio].EsAliado = tableroNoAleatorio[i].EsAliado;
                tablero[numeroAleatorio].Imagen = "reverso.jpg";
            }

        }

        /// <summary>
        /// Metodo que comprueba las cartas ya pulsadas si son enemigas o aliadas, 
        /// para saber si ha sido pulsada se comprueba por la imagen, que si la imagen es 
        /// reverso significa no ha sido pulsada.
        /// Y muestra por pantalla el mensaje
        /// </summary>
        private async void comprobarGanador()
        {
            int contadorAliados = 0;
            int contadorEnemigos = 0;
            for (int i = 0; i < tablero.Count; i++)
            {
                if (tablero[i].EsAliado == true && tablero[i].Imagen != "reverso.jpg")
                {
                    contadorAliados++;
                }
                else if (tablero[i].EsAliado == false && tablero[i].Imagen != "reverso.jpg")
                {
                    contadorEnemigos++;
                }
            }
            if (contadorAliados >= 3)
            {
                await Application.Current.MainPage.DisplayAlert("Has ganado", "Quieres Continuar", "Si", "No");
            }
            else if (contadorEnemigos >= 3)
            {
                await Application.Current.MainPage.DisplayAlert("Has perdido", "Quieres Continuar", "Si", "No");
            }
        }

        /// <summary>
        /// Metodo que comprueba si puede girar la carta, para
        /// ello coprueba la imagen, que despues de pulsarla girara, por lo 
        /// que no se podra pulsar la misma carta 2 veces
        /// </summary>
        /// <returns></returns>
        private bool pulsarCartaCommand_CanExecute()
        {
            bool ejecutar = false;
            if (cartaSeleccionada.Imagen == "reverso.jpg")
            {
                ejecutar = true;
            }
            return ejecutar;
        }
        /// <summary>
        /// Metodo que cambia la imagen de la carta seleccionada y lo cambia
        /// en el listado de tablero
        /// </summary>
        private void pulsarCartaCommand_Executed()
        {
            bool aInsertado = false;
            for (int i = 0; i < listaCartas.Count; i++)
            {
                if (listaCartas[i].Id == cartaSeleccionada.Id)
                {
                    cartaSeleccionada.Imagen = listaCartas[i].Imagen;

                }
            }
            for (int i = 0; i < tablero.Count; i++)
            {
                if (tablero[i].Id == cartaSeleccionada.Id && aInsertado == false)
                {
                    tablero[i].Imagen = cartaSeleccionada.Imagen;
                    aInsertado = true;
                    
                }
            }
            comprobarGanador();
        }
    
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
