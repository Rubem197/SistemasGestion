using ExamenRubenLindes_Entidades;
using ExamenRubenLindes_DAL;

namespace ExamenRubenLindes_BL
{
    public class clsListadoDepartamentoBL
    {
        public static List<clsDepartamento> ListadoCompletoDepartamentos()
        {
            return clsListadoDepartamentoDAL.ListadoCompletoDepartamentos();
        }
    }
}
