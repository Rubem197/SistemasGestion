using CRUD_Personas_DAL.Utilidades;
using CRUD_Personas_Entidades;
using Microsoft.Data.SqlClient;

namespace CRUD_Personas_DAL
{
    public class obtenerListadoDepartamentos
    {
        public static List<clsDepartamentos> ListadoCompletoDepartamentos()
        {
            List<clsDepartamentos> lista = new List<clsDepartamentos>();
            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            clsDepartamentos departamento;

            try
            {
                comando.Connection = miCon.getConnection();
                comando.CommandText = "SELECT * FROM Departamentos";
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        departamento = new clsDepartamentos();
                        departamento.Id = (int)lector["ID"];
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
