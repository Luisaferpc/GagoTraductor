using System.Data;
using Microsoft.Data.SqlClient;

namespace Gago.Library.Datos
{
    public class Consultas
    {
        private const string SqlBase = @"SELECT p.CodigoPalabra AS Código,
                                                p.PalabraEspanol AS Palabra,
                                                i.Idioma AS Idioma,
                                                t.Traduccion AS Traducción
                                         FROM Palabras p
                                         INNER JOIN Traducciones t ON t.PalabraId = p.IdPalabra
                                         INNER JOIN Idiomas i ON i.IdIdioma = t.IdiomaId ";

        public DataTable PorCodigo(string codigo)
        {
            string sql = SqlBase + "WHERE p.CodigoPalabra = @valor ORDER BY i.IdIdioma";
            return Ejecutar(sql, codigo);
        }

        public DataTable PorPalabra(string palabra)
        {
            string sql = SqlBase + "WHERE p.PalabraEspanol LIKE @valor ORDER BY p.IdPalabra, i.IdIdioma";
            return Ejecutar(sql, "%" + palabra + "%");
        }

        private DataTable Ejecutar(string sql, string valor)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sql, conexion))
            {
                comando.Parameters.AddWithValue("@valor", valor);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    tabla.Load(lector);
                }
            }

            return tabla;
        }
    }
}
