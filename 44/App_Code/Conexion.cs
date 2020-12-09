using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
/// <summary>
/// Descripción breve de Conexion
/// </summary>
/// 
namespace IO.App_Code
{
    public class Conexion
    {

        private static MySqlConnection objConexion;
        private static string error;
        public static MySqlConnection getConexion()
        {
            if (objConexion != null)
                return objConexion;
            objConexion = new MySqlConnection("server=localhost; database=prueba; user id=root; password=thelove123");
            try
            {
                objConexion.Open();
                return objConexion;
            }
            catch (Exception e)
            {

                error = e.Message;
                return null;
            }
        }
        public static void cerrarConexion()
        {
            if (objConexion != null)
                objConexion.Close();
        }

    }
}