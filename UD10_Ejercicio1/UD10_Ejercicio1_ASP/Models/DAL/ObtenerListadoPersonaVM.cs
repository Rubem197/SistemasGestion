using Microsoft.Data.SqlClient;

namespace UD10_Ejercicio1_ASP.Models.DAL
{
    public class ObtenerListadoPersonaVM
    {
        public static List<clsPersona> ObtenerPersonas()
        {

            List<clsPersona> lista = new List<clsPersona>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            clsPersona persona;

            conexion.ConnectionString = "server=rlindes.database.windows.net;database=rubenDB;uid=fernando;pwd=Mandaloriano69;";
            try
            {
                conexion.Open();
                comando.CommandText = "Select * from Personas";
                comando.Connection = conexion;
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        persona = new clsPersona();
                        persona.Id = (int)lector["ID"];
                        persona.Nombre = (String)lector["Nombre"];
                        persona.Apellidos = (String)lector["Apellidos"];
                        persona.Telefono = (String)lector["Telefono"];
                        persona.Direccion = (String)lector["Direccion"];
                        persona.Foto = (String)lector["Foto"];
                        persona.IdDepartamento = (int)lector["IdDepartamento"];
                        lista.Add(persona);
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }
    }
}
