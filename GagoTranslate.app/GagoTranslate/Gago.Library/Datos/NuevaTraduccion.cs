using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gago.Library.Datos
{
    public class NuevaTraduccion
    {
        // Método de ejemplo para buscar la traducción de una palabra según el idioma destino
        public string ObtenerTraduccion(string palabraEspanol, string abreviacionIdioma)
        {
            string traduccionResultado = string.Empty;
            string query = @"SELECT t.Traduccion 
                             FROM Traducciones t
                             INNER JOIN Palabras p ON t.PalabraId = p.IdPalabra
                             INNER JOIN Idiomas i ON t.IdiomaId = i.IdIdioma
                             WHERE p.PalabraEspanol = @palabra AND i.Abreviacion = @idioma";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@palabra", palabraEspanol);
                    comando.Parameters.AddWithValue("@idioma", abreviacionIdioma);

                    object resultado = comando.ExecuteScalar();
                    if (resultado != null)
                    {
                        traduccionResultado = resultado.ToString();
                    }
                }
            }
            return traduccionResultado;
        }

        // Insertar una nueva traducción asociada a una palabra y un idioma
        public bool InsertarTraduccion(int palabraId, int idiomaId, string textoTraduccion)
        {
            string query = "INSERT INTO Traducciones (PalabraId, IdiomaId, Traduccion) VALUES (@palabraId, @idiomaId, @traduccion)";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@palabraId", palabraId);
                    comando.Parameters.AddWithValue("@idiomaId", idiomaId);
                    comando.Parameters.AddWithValue("@traduccion", textoTraduccion);
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
