using Gago.Library.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gago.Library.Datos
{
    public class NuevoUsuario
    {

        public Usuario ValidarLogin(string nombreUsuario, string clave)
        {
            Usuario usuario = null;
            string query = "SELECT IdUsuario, NombreUsuario, Clave, Rol FROM Usuarios WHERE NombreUsuario = @usuario AND Clave = @clave";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@clave", clave);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            usuario = new Usuario
                            {
                                IdUsuario = lector.GetInt32(0),
                                NombreUsuario = lector.GetString(1),
                                Clave = lector.GetString(2),
                                Rol = lector.GetInt32(3)
                            };
                        }
                    }
                }
            }
            return usuario;
        }
    }
}
