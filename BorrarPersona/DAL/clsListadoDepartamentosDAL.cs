using Entidades;

namespace DAL
{
    public class clsListadoDepartamentosDAL
    {
        /// <summary>
        /// Accedemos a la base de datos y devolvemos un listado completo de departamentos.
        /// Precondiciones: la base de datos debe estar accesible
        /// Postcondiciones: ninguna 
        /// </summary>
        /// <returns>List<clsDepartamento></returns>
        public static List<clsDepartamento> obtenerListadoCompletoDepartamento()
        {
            List<clsDepartamento> listaDepartamento = new List<clsDepartamento>();

            listaDepartamento.Add(new clsDepartamento(1,"awa"));

            listaDepartamento.Add(new clsDepartamento(2, "awo"));

            return listaDepartamento;
        }
    }
}