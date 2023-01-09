using ExamenRubenLindes_DAL;
using ExamenRubenLindes_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRubenLindes_BL
{
    public class clsManejadoraDepartamentoBL
    {
        public static int borrarDepartamento(int id)
        {
            return clsManejadoraDepartamentoDAL.borrarDepartamentos(id);
        }
    }
}
