using System;
using System.Data;
using System.Data.SqlClient;
using Examen_KY.Models.Entity;
using Examen_KY.Models.Interface;
using Examen_KY.Models.SQL;
using Examen_KY.Helper;

namespace Examen_KY.Models.Persistence
{
    public class P_Libro : P_ConnectionString, I_Libro
    {
        /// <summary>
        /// Obtener libro(s) segun parametro: IdLibro (opcional)
        /// </summary>
        /// <param name="IdLibro">Codigo de libro</param>
        /// <param name="Nombre_Libro">Nombre de libro</param>
        /// <param name="NomAutor">Nombre de autor</param>
        /// <returns>dtsEquipment</returns>
        public DataSet GetLibro(int IdLibro, string Nombre_Libro, string NomAutor)
        {
            var dtsLibro = new DataSet();
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = sqlConn;
            using (sqlConn)
            {
                try
                {
                    sqlConn.Open();
                    using (SqlDataAdapter sqldt = new SqlDataAdapter())
                    {
                        sqlcomm.CommandText = SQL_Libro.SP_GET_LIBRO;
                        sqlcomm.Parameters.Add(SQL_Libro.PARAM_LIBRO_ID, SqlDbType.Int).Value = Utils.CheckNullValue(IdLibro);
                        sqlcomm.Parameters.Add(SQL_Libro.PARAM_LIBRO_NOMBRE, SqlDbType.VarChar).Value = Utils.CheckNullValue(Nombre_Libro);
                        sqlcomm.Parameters.Add(SQL_Autor.PARAM_AUTOR_NOMBRES, SqlDbType.VarChar).Value = Utils.CheckNullValue(NomAutor);
                        sqlcomm.Parameters.Add(SQL_Autor.PARAM_AUTOR_APELLIDOS, SqlDbType.VarChar).Value = Utils.CheckNullValue(NomAutor);
                        sqldt.SelectCommand = sqlcomm;
                        sqldt.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqldt.Fill(dtsLibro, "Libro");
                    }
                    sqlConn.Close();
                }
                catch (SqlException ex)
                {
                    dtsLibro = GetErrorDataSet("SqlException", ex.Message);
                }
                catch (Exception e)
                {
                    dtsLibro = GetErrorDataSet("Exception", e.Message);
                }
            }
            return dtsLibro;
        }

        /// <summary>
        /// Insertar un libro
        /// </summary>
        /// <param name="dataLibro">Entidad de equipo</param>
        /// <returns>mensaje</returns>
        public string InsertLibro(E_Libro dataLibro)
        {
            string message = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL_Libro.SP_INS_LIBRO, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(SQL_Libro.PARAM_LIBRO_ID, SqlDbType.VarChar).Value = dataLibro.IdLibro;
                    command.Parameters.Add(SQL_Libro.PARAM_LIBRO_NOMBRE, SqlDbType.Decimal).Value = dataLibro.Nombre_Libro;
                    command.Parameters.Add(SQL_Libro.PARAM_LIBRO_DESCRIPCION, SqlDbType.Decimal).Value = dataLibro.Desc_Libro;
                    command.Parameters.Add(SQL_Autor.PARAM_AUTOR_ID, SqlDbType.Int).Value = dataLibro.IdAutor;
                    command.Parameters.Add(SQL_Editorial.PARAM_EDITORIAL_ID, SqlDbType.Int).Value = dataLibro.IdEditorial;
                    command.ExecuteReader(CommandBehavior.SingleResult);
                    connection.Close();
                    message = "success";
                }
            }
            catch (SqlException ex)
            {
                message = "SqlException: " + ex.Message;
            }
            return message;
        }

        /// <summary>
        /// Actualizar un libro
        /// </summary>
        /// <param name="dataLibro">Entidad de equipo</param>
        /// <returns>mensaje</returns>
        public string UpdateLibro(E_Libro dataLibro)
        {
            string message = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL_Libro.SP_INS_LIBRO, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(SQL_Libro.PARAM_LIBRO_ID, SqlDbType.VarChar).Value = dataLibro.IdLibro;
                    command.Parameters.Add(SQL_Libro.PARAM_LIBRO_NOMBRE, SqlDbType.VarChar).Value = dataLibro.Nombre_Libro;
                    command.Parameters.Add(SQL_Libro.PARAM_LIBRO_DESCRIPCION, SqlDbType.VarChar).Value = dataLibro.Desc_Libro;
                    command.Parameters.Add(SQL_Autor.PARAM_AUTOR_ID, SqlDbType.Int).Value = dataLibro.IdAutor;
                    command.Parameters.Add(SQL_Autor.PARAM_AUTOR_ID, SqlDbType.Int).Value = dataLibro.IdEditorial;
                    command.ExecuteReader(CommandBehavior.SingleResult);
                    connection.Close();
                    message = "success";
                }
            }
            catch (SqlException ex)
            {
                message = "SqlException: " + ex.Message;
            }
            return message;
        }

        /// <summary>
        /// Eliminar un libro
        /// </summary>
        /// <param name="IdLibro">Codigo de Formulario</param>
        /// <returns>mensaje</returns>
        public string DeleteLibro(int IdLibro)
        {
            string message = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL_Libro.SP_DEL_LIBRO, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(SQL_Libro.PARAM_LIBRO_ID, SqlDbType.VarChar).Value = IdLibro;
                    command.ExecuteReader(CommandBehavior.SingleResult);
                    connection.Close();
                    message = "success";
                }
            }
            catch (SqlException ex)
            {
                message = "SqlException: " + ex.Message;
            }
            return message;
        }
    }
}