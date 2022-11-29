using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_BL
{
    public class clsManejadoraDepartamentoBL
    {
        public static int borrarDepartamento(int id)
        {
            return clsManejadoraDepartamentoDAL.borrarDepartamentos(id);
        }
        public static int editarDepartamento(clsDepartamentos departamento)
        {
            return clsManejadoraDepartamentoDAL.editarDepartamentos(departamento);
        }

        public static int insertarDepartamento(clsDepartamentos departamento)
        {
            return clsManejadoraDepartamentoDAL.insertarDepartamentos(departamento);
        }
    }
}
