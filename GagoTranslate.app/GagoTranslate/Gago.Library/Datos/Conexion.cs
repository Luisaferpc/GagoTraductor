using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gago.Library.Datos
{
    public class Conexion
    {

        private static string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Traductor;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
