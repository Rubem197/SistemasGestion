using CRUD_Personas_DAL.Utilidades;
using CRUD_Personas_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_DAL
{
    public class clsManejadoraPersonaDAL
    {
        public static int insertarPersona(clsPersonas persona) {
            int filasAfectadas = 0;




            return filasAfectadas;
        }

        public static int borrarPersonas(int id){
            int filasAfectadas = 0;

            List<clsPersonas> lista = new List<clsPersonas>();
            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value=id;
                comando.Connection = miCon.getConnection();
                comando.CommandText = "DELETE FROM Personas WHERE ID =@id";
                comando.ExecuteNonQuery();
            }
            catch (SqlException e) 
            {
                throw e;
            }

                return filasAfectadas;
        }
    }
}
