using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_Entidades
{
    public class clsDepartamentos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public clsDepartamentos()
        {
                
        }
        public clsDepartamentos(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
