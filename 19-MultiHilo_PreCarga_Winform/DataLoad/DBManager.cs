using Empleados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoad
{
    public class DBManager
    {
        private readonly string _nombreDb;
        private readonly string _conn;
        private SqlConnection SqlConexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public DBManager(string connectionString, string dbName)
        {
            _nombreDb = dbName;
            _conn = connectionString;
            CreateDatabaseIfNotExists(connectionString, dbName);
        }
        private void CreateDatabaseIfNotExists(string connectionString, string dbName)
        {
            SqlCommand cmd = null;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (cmd = new SqlCommand($"If(db_id(N'{dbName}') IS NULL) CREATE DATABASE [{dbName}]", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Empleado> ObtenerListaEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();

            try
            {
                var comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM dbo.Empleados";
                comando.Connection = new SqlConnection(_conn);

                SqlConexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Empleado e = new Empleado();
                    e.Nombre = lector["nombre"].ToString();
                    e.Mail = lector["mail"].ToString();
                    lista.Add(e);
                }
                lector.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }
            return lista;
        }
    }
}
