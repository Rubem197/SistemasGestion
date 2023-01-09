using ExamenRubenLindes_DAL.Utilidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRubenLindes_DAL
{
    public class clsManejadoraPersonaDAL
    {
        /// <summary>
        /// Metodo que recibe una id y la borra en la base de datos
        /// Postcondicion: Returna un entero con las filas afectadas
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int borrarPersonas(int id)
        {
            int filasAfectadas = 0;

            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                comando.Connection = miCon.getConnection();
                comando.CommandText = "DELETE FROM Personas WHERE IDDepartamento =@id";
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }

            return filasAfectadas;
        }
  
    }
}
