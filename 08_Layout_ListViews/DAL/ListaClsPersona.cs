using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListaClsPersona
    {
        public static ObservableCollection<clsPersona> listadoPersona()
        {
            ObservableCollection<clsPersona> listaPersona = new ObservableCollection<clsPersona>();

            listaPersona.Add(new clsPersona("Ricardo","Milos"));
            listaPersona.Add(new clsPersona("Antonio","Rodriguez"));
            listaPersona.Add(new clsPersona("Turip", "Ip Ip"));
            listaPersona.Add(new clsPersona("Walter", "Dog"));
            listaPersona.Add(new clsPersona("Miguel", "Pana"));
            listaPersona.Add(new clsPersona("ASASA", "ASASA"));
            listaPersona.Add(new clsPersona("Qwe", "Rty"));

            return listaPersona;
        }
    }
}
