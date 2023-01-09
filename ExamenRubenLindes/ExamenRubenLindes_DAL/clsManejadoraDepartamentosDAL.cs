using ExamenRubenLindes_DAL.Utilidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRubenLindes_DAL
{
    public class clsManejadoraDepartamentoDAL
    {
        /// <summary>
        /// Metodo que recibe una id y borra un departamento por la id
        /// postcondicion: Returna un entero con las filas afectadas
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int borrarDepartamentos(int id)
        {
            int filasAfectadas = 0;

            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                comando.Connection = miCon.getConnection();
                comando.CommandText = "DELETE FROM Departamentos WHERE ID =@id";
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
