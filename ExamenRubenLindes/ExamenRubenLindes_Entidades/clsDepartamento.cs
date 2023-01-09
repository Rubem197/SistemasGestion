using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRubenLindes_Entidades
{
    public class clsDepartamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public clsDepartamento()
        {

        }
        public clsDepartamento(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
