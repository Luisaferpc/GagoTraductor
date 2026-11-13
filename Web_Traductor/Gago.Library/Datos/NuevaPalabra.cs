using Gago.Library.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gago.Library.Datos
{
    public class NuevaPalabra
    {
        // Método para registrar una nueva palabra en español
        public bool InsertarPalabra(string palabraEspanol, string codigoPalabra)
        {
            string query = "INSERT INTO Palabras (PalabraEspanol, CodigoPalabra) VALUES (@palabra, @codigo)";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@palabra", palabraEspanol);
                    comando.Parameters.AddWithValue("@codigo", codigoPalabra);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // Buscar palabra por Código
        public Palabra BuscarPorCodigo(string codigoPalabra)
        {
            Palabra palabra = null;
            string query = "SELECT IdPalabra, PalabraEspanol, CodigoPalabra FROM Palabras WHERE CodigoPalabra = @codigo";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@codigo", codigoPalabra);
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            palabra = new Palabra
                            {
                                IdPalabra = lector.GetInt32(0),
                                PalabraEspanol = lector.GetString(1),
                                CodigoPalabra = lector.GetString(2)
                            };
                        }
                    }
                }
            }
            return palabra;
        }

        // Buscar palabra por texto en Español
        public Palabra BuscarPorEspanol(string palabraEspanol)
        {
            Palabra palabra = null;
            string query = "SELECT IdPalabra, PalabraEspanol, CodigoPalabra FROM Palabras WHERE PalabraEspanol = @palabra";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@palabra", palabraEspanol);
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            palabra = new Palabra
                            {
                                IdPalabra = lector.GetInt32(0),
                                PalabraEspanol = lector.GetString(1),
                                CodigoPalabra = lector.GetString(2)
                            };
                        }
                    }
                }
            }
            return palabra;
        }

        public bool ActualizarPalabra(int idPalabra, string nuevaPalabraEspanol, string nuevoCodigo)
        {
            string query = "UPDATE Palabras SET PalabraEspanol = @palabra, CodigoPalabra = @codigo WHERE IdPalabra = @id";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@palabra", nuevaPalabraEspanol);
                    comando.Parameters.AddWithValue("@codigo", nuevoCodigo);
                    comando.Parameters.AddWithValue("@id", idPalabra);
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Eliminar palabra
        public bool EliminarPalabra(int idPalabra)
        {
            string query = "DELETE FROM Palabras WHERE IdPalabra = @id";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idPalabra);
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
