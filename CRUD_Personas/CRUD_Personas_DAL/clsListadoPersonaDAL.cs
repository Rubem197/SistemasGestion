using CRUD_Personas_DAL.Utilidades;
using CRUD_Personas_Entidades;
using Microsoft.Data.SqlClient;

namespace CRUD_Personas_DAL
{
    public class clsListadoPersonaDAL
    {
        /// <summary>
        /// Metodo que recoge todos los datos de personas de la base de datos
        /// y lo inserta en una lista de personas
        /// postcondicion: Devolvera una lista de personas.
        /// </summary>
        /// <returns></returns>
        public static List<clsPersonas> ListadoCompletoPersonas()
        {
            List<clsPersonas> lista = new List<clsPersonas>();
            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            clsPersonas persona;



            try
            {
                comando.Connection = miCon.getConnection();
                comando.CommandText = "SELECT * FROM Personas";
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        persona = new clsPersonas();
                        persona.Id = (int)lector["ID"];
                        persona.Nombre = (string)lector["Nombre"];
                        persona.Apellidos = (string)lector["Apellidos"];
                        persona.Telefono = (string)lector["Telefono"];
                        persona.Direccion = (string)lector["Direccion"];
                        persona.Foto = (string)lector["Foto"];
                        persona.FechaNacimiento = (DateTime)lector["FechaNacimiento"];
                        if (lector["IDDepartamento"] != System.DBNull.Value)
                        {
                            persona.IdDepartamento = (int)lector["IDDepartamento"] - 1;
                        }
                        else
                        {
                            persona.IdDepartamento = -1;
                        }
                        lista.Add(persona);
                    }
                }
            }
            catch(SqlException e) 
            {
                throw e;
            }

            return lista;
        }
    }
}