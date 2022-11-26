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

        public static int borrarPersonas(int id){
            int filasAfectadas = 0;

            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value=id;
                comando.Connection = miCon.getConnection();
                comando.CommandText = "DELETE FROM Personas WHERE ID =@id";
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (SqlException e) 
            {
                throw e;
            }

                return filasAfectadas;
        }

        public static int editarPersonas(clsPersonas persona)
        {
            int filasAfectadas = 0;

            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();
            clsPersonas personaCon = new clsPersonas();

            try
            {
                comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = persona.Id;
                comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
                comando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
                comando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.Telefono;
                comando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.Direccion;
                comando.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.Date).Value = persona.FechaNacimiento;
                comando.Parameters.Add("@idDepartamento", System.Data.SqlDbType.Int).Value = persona.IdDepartamento+1;
                comando.Connection = miCon.getConnection();
                comando.CommandText = "UPDATE Personas SET Nombre=@nombre, Apellidos=@apellidos, " +
                        "Telefono=@telefono, Direccion=@direccion, FechaNacimiento=@fechaNacimiento, " +
                        "IdDepartamento=@idDepartamento WHERE ID =@id";
                filasAfectadas = comando.ExecuteNonQuery();

            }
            catch(SqlException e)
            {
                throw e;
            }

            return filasAfectadas;
        }

        public static int insertarPersonas(clsPersonas persona)
        {
            int filasAfectadas = 0;

            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();
            clsPersonas personaCon = new clsPersonas();

            try
            {
                comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
                comando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
                comando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.Telefono;
                comando.Parameters.Add("@foto", System.Data.SqlDbType.VarChar).Value = persona.Foto;
                comando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.Direccion;
                comando.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.Date).Value = persona.FechaNacimiento;
                comando.Parameters.Add("@idDepartamento", System.Data.SqlDbType.Int).Value = persona.IdDepartamento + 1;
                comando.Connection = miCon.getConnection();
                comando.CommandText = "Insert into Personas Values ( @nombre, @apellidos, " +
                        "@telefono, @direccion, @foto, @fechaNacimiento, " +
                        " @idDepartamento)";
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
