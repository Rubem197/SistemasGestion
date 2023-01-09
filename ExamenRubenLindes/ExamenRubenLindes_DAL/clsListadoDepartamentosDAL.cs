using ExamenRubenLindes_DAL.Utilidades;
using ExamenRubenLindes_Entidades;
using Microsoft.Data.SqlClient;

namespace ExamenRubenLindes_DAL
{
    public class clsListadoDepartamentoDAL
    {
        /// <summary>
        /// Metodo que recoge todos los datos de departamentos de la base de datos
        /// y lo inserta en una lista de departamentos
        /// postcondicion: Devolvera una lista de departamentos.
        /// </summary>
        /// <returns></returns>
        public static List<clsDepartamento> ListadoCompletoDepartamentos()
        {
            List<clsDepartamento> lista = new List<clsDepartamento>();
            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            clsDepartamento departamento;

            try
            {
                comando.Connection = miCon.getConnection();
                comando.CommandText = "SELECT * FROM Departamentos";
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        departamento = new clsDepartamento();
                        departamento.Id = ((int)lector["ID"]);
                        departamento.Nombre = (string)lector["Nombre"];
                        lista.Add(departamento);
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

            return lista;
        }
    }
}
