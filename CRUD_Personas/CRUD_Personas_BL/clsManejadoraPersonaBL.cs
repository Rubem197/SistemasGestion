using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_BL
{
    public class clsManejadoraPersonaBL
    {
        public static int borrarPersonas(int id)
        {
            return clsManejadoraPersonaDAL.borrarPersonas(id);
        }
        public static int editarPersonas(clsPersonas persona)
        {
            return clsManejadoraPersonaDAL.editarPersonas(persona);
        }
    }
}
