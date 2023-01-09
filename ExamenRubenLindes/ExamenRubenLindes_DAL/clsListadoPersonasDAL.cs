using ExamenRubenLindes_DAL.Utilidades;
using ExamenRubenLindes_Entidades;
using Microsoft.Data.SqlClient;

namespace ExamenRubenLindes_DAL
{
    public class clsListadoPersonaDAL
    {
        /// <summary>
        /// Metodo que recoge todos los datos de personas de la base de datos
        /// y lo inserta en una lista de personas
        /// postcondicion: Devolvera una lista de personas.
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> ListadoCompletoPersonas()
        {
            List<clsPersona> lista = new List<clsPersona>();
            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            clsPersona persona;



            try
            {
                comando.Connection = miCon.getConnection();
                comando.CommandText = "SELECT * FROM Personas";
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        persona = new clsPersona();
                        persona.Id = (int)lector["ID"];
                        persona.Nombre = (string)lector["Nombre"];
                        persona.Apellidos = (string)lector["Apellidos"];
                        persona.Telefono = (string)lector["Telefono"];
                        persona.Direccion = (string)lector["Direccion"];
                        persona.Foto = (string)lector["Foto"];
                        persona.FechaNacimiento = (DateTime)lector["FechaNacimiento"];
                        if (lector["IDDepartamento"] != System.DBNull.Value)
                        {
                            persona.IdDepartamento = (int)lector["IDDepartamento"];
                        }
                        else
                        {
                            persona.IdDepartamento = -1;
                        }
                        lista.Add(persona);
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