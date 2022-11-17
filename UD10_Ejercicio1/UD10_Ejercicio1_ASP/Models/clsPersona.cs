using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD10_Ejercicio1_ASP.Models
{

    public class clsPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Foto { get; set; }
        public int IdDepartamento { get; set; }
        public DateTime FechaNacimineto { get; set; }




        public clsPersona()
        {

        }

        public clsPersona(int id, string nombre, string apellidos, string telefono, string direccion, string foto, int idDepartamento, DateTime fechaNacimiento) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Foto = foto;
            this.IdDepartamento = idDepartamento;
            this.FechaNacimineto = fechaNacimiento;
        }


    }

}
