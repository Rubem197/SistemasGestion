using CRUD_Personas_DAL;
using CRUD_Personas_Entidades;

namespace CRUD_Personas_BL
{
    public class clsListadoDepartamentoBL
    {
        public static List<clsDepartamentos> ListadoCompletoDepartamentos()
        {
            return clsListadoDepartamentoDAL.ListadoCompletoDepartamentos();
        }
    }
}
