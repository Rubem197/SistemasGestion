using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ListaClsPersona
    {
        public static List<clsPersona> listadoPersona()
        {
            List<clsPersona> listaPersona = new List<clsPersona>();

            listaPersona.Add(new clsPersona());

            listaPersona.Add(new clsPersona());

            return listaPersona;
        }

    }
}
