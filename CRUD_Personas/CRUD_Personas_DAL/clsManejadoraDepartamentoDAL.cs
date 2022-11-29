﻿using CRUD_Personas_DAL.Utilidades;
using CRUD_Personas_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_DAL
{
    public class clsManejadoraDepartamentoDAL
    {

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

        public static int editarDepartamentos(clsDepartamentos departamento)
        {
            int filasAfectadas = 0;

            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = departamento.Id;
                comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = departamento.Nombre;
                comando.Connection = miCon.getConnection();
                comando.CommandText = "UPDATE Departamentos SET Nombre=@nombre WHERE ID =@id";
                filasAfectadas = comando.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw e;
            }

            return filasAfectadas;
        }

        public static int insertarDepartamentos(clsDepartamentos departamento)
        {
            int filasAfectadas = 0;

            clsMyConnection miCon = new clsMyConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = departamento.Nombre;
                comando.Connection = miCon.getConnection();
                comando.CommandText = "Insert into Departamentos Values (@nombre)";
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
