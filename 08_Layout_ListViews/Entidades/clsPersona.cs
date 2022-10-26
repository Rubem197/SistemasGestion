using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsPersona
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }

        public clsPersona() { 
        
        }

        public clsPersona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellidos = apellido;
        }
    }
}
