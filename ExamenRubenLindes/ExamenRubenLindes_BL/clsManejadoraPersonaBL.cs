using ExamenRubenLindes_DAL;
using ExamenRubenLindes_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRubenLindes_BL
{
    public class clsManejadoraPersonaBL
    {
        public static int borrarPersonas(int id)
        {
            return clsManejadoraPersonaDAL.borrarPersonas(id);
        }
    }
}
