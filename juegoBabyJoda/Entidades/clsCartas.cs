using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsCartas
    {
        #region Atributos
        private int id;
        private string nombre;
        private string imagen;
        private bool esAliado;
        #endregion
        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public bool EsAliado
        {
            get { return esAliado; }
            set { esAliado = value; }
        }
        #endregion
        #region Constructor
        public clsCartas()
        {

        }
        public clsCartas(int id, string nombre, string imagen, bool esAliado)
        {
            Id = id;
            Nombre = nombre;
            Imagen = imagen;
            EsAliado = esAliado;
        }

        #endregion

    }
}
