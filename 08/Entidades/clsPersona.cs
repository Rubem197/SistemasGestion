using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsPersona
    {
        [Required(ErrorMessage ="Campo obligatorio")]
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }

        public clsPersona()
        {

        }
        public clsPersona(string nombre, string apellidos, string direccion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
        }
    }
}
