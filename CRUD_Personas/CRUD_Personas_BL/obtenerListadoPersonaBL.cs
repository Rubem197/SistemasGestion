using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_BL
{
    public class obtenerListadoPersonaBL
    {
        public static List<clsPersonas> ListadoCompletoPersonas()
        {
            return ObtenerListadoPersonas.ListadoCompletoPersonas();   
        }
    }
}
