using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsPersona
    {
        int id;
        string nombre;
        string apellidos;
        int telefono;
        string direccion;
        int idDepartamento;

        public clsPersona()
        {
            this.id = 1;
            this.nombre = "Rubén";
            this.apellidos = "Lindes Roldan";
            this.telefono = 644728232;
            this.direccion = "Barriada Felipe II";
            this.idDepartamento = 1;
        }
        public clsPersona(int id, string nombre, string apellidos, int telefono, string direccion, int idDepartamento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.idDepartamento = idDepartamento;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
            }
        }
        public int Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }
        public int IdDepartamento
        {
            get
            {
                return idDepartamento;
            }
            set
            {
                idDepartamento = value;
            }
        }
    }
}
