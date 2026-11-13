using Gago.Library.Entidades;
using Microsoft.Data.SqlClient;

namespace Gago.Library.Datos
{
    public class GestionPalabras
    {
        public string Registrar(string espanol, string ingles, string frances, string aleman)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlTransaction tx = con.BeginTransaction())
            {
                if (ExisteEspanol(con, tx, espanol, 0))
                    throw new InvalidOperationException("Esa palabra ya está registrada.");

                string codigo = SiguienteCodigo(con, tx);

                int idPalabra;
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Palabras (PalabraEspanol, CodigoPalabra) OUTPUT INSERTED.IdPalabra VALUES (@e, @c)", con, tx))
                {
                    cmd.Parameters.AddWithValue("@e", espanol);
                    cmd.Parameters.AddWithValue("@c", codigo);
                    idPalabra = (int)cmd.ExecuteScalar();
                }

                GuardarTraduccion(con, tx, idPalabra, "ES", espanol);
                GuardarTraduccion(con, tx, idPalabra, "EN", ingles);
                GuardarTraduccion(con, tx, idPalabra, "FR", frances);
                GuardarTraduccion(con, tx, idPalabra, "AL", aleman);

                tx.Commit();
                return codigo;
            }
        }

        public PalabraCompleta? BuscarCompletaPorCodigo(string codigo)
        {
            string sql = @"SELECT p.IdPalabra, p.CodigoPalabra, p.PalabraEspanol,
                                  MAX(CASE WHEN i.Abreviacion = 'EN' THEN t.Traduccion END) AS Ingles,
                                  MAX(CASE WHEN i.Abreviacion = 'FR' THEN t.Traduccion END) AS Frances,
                                  MAX(CASE WHEN i.Abreviacion = 'AL' THEN t.Traduccion END) AS Aleman
                           FROM Palabras p
                           LEFT JOIN Traducciones t ON t.PalabraId = p.IdPalabra
                           LEFT JOIN Idiomas i ON i.IdIdioma = t.IdiomaId
                           WHERE p.CodigoPalabra = @codigo
                           GROUP BY p.IdPalabra, p.CodigoPalabra, p.PalabraEspanol";

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (!lector.Read())
                        return null;

                    return new PalabraCompleta
                    {
                        IdPalabra = lector.GetInt32(0),
                        CodigoPalabra = lector.GetString(1),
                        PalabraEspanol = lector.GetString(2),
                        Ingles = lector.IsDBNull(3) ? "" : lector.GetString(3),
                        Frances = lector.IsDBNull(4) ? "" : lector.GetString(4),
                        Aleman = lector.IsDBNull(5) ? "" : lector.GetString(5)
                    };
                }
            }
        }

        public void Modificar(PalabraCompleta p)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlTransaction tx = con.BeginTransaction())
            {
                if (ExisteEspanol(con, tx, p.PalabraEspanol, p.IdPalabra))
                    throw new InvalidOperationException("Ya existe otra palabra con ese texto en español.");

                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Palabras SET PalabraEspanol = @e WHERE IdPalabra = @id", con, tx))
                {
                    cmd.Parameters.AddWithValue("@e", p.PalabraEspanol);
                    cmd.Parameters.AddWithValue("@id", p.IdPalabra);
                    cmd.ExecuteNonQuery();
                }

                GuardarTraduccion(con, tx, p.IdPalabra, "ES", p.PalabraEspanol);
                GuardarTraduccion(con, tx, p.IdPalabra, "EN", p.Ingles);
                GuardarTraduccion(con, tx, p.IdPalabra, "FR", p.Frances);
                GuardarTraduccion(con, tx, p.IdPalabra, "AL", p.Aleman);

                tx.Commit();
            }
        }

        public bool Eliminar(int IdPalabra)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlTransaction tx = con.BeginTransaction())
            {
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Traducciones WHERE PalabraId = @id", con, tx))
                {
                    cmd.Parameters.AddWithValue("@id", IdPalabra);
                    cmd.ExecuteNonQuery();
                }

                int filas;
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Palabras WHERE IdPalabra = @id", con, tx))
                {
                    cmd.Parameters.AddWithValue("@id", IdPalabra);
                    filas = cmd.ExecuteNonQuery();
                }

                tx.Commit();
                return filas > 0;
            }
        }

        private static bool ExisteEspanol(SqlConnection con, SqlTransaction tx, string espanol, int idExcluir)
        {
            using (SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Palabras WHERE PalabraEspanol = @e AND IdPalabra <> @id", con, tx))
            {
                cmd.Parameters.AddWithValue("@e", espanol);
                cmd.Parameters.AddWithValue("@id", idExcluir);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private static string SiguienteCodigo(SqlConnection con, SqlTransaction tx)
        {
            using (SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(CodigoPalabra, 2, 10) AS int)), 0) + 1 FROM Palabras", con, tx))
            {
                int siguiente = (int)cmd.ExecuteScalar();
                return "P" + siguiente.ToString("000");
            }
        }

        private static void GuardarTraduccion(SqlConnection con, SqlTransaction tx, int idPalabra, string abreviacion, string texto)
        {
            int filas;
            using (SqlCommand cmd = new SqlCommand(
                @"UPDATE Traducciones SET Traduccion = @t
                  WHERE PalabraId = @id
                    AND IdiomaId = (SELECT IdIdioma FROM Idiomas WHERE Abreviacion = @ab)", con, tx))
            {
                cmd.Parameters.AddWithValue("@t", texto);
                cmd.Parameters.AddWithValue("@id", idPalabra);
                cmd.Parameters.AddWithValue("@ab", abreviacion);
                filas = cmd.ExecuteNonQuery();
            }

            if (filas == 0)
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Traducciones (PalabraId, IdiomaId, Traduccion)
                      SELECT @id, IdIdioma, @t FROM Idiomas WHERE Abreviacion = @ab", con, tx))
                {
                    cmd.Parameters.AddWithValue("@t", texto);
                    cmd.Parameters.AddWithValue("@id", idPalabra);
                    cmd.Parameters.AddWithValue("@ab", abreviacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public PalabraCompleta BuscarCompletaPorEspanol(string espanol)
        {
            string sql = @"SELECT p.IdPalabra, p.CodigoPalabra, p.PalabraEspanol,
                  MAX(CASE WHEN i.Abreviacion = 'EN' THEN t.Traduccion END) AS Ingles,
                  MAX(CASE WHEN i.Abreviacion = 'FR' THEN t.Traduccion END) AS Frances,
                  MAX(CASE WHEN i.Abreviacion = 'AL' THEN t.Traduccion END) AS Aleman
                  FROM Palabras p
                  LEFT JOIN Traducciones t ON t.PalabraId = p.IdPalabra
                  LEFT JOIN Idiomas i ON i.IdIdioma = t.IdiomaId
                  WHERE p.PalabraEspanol = @espanol
                  GROUP BY p.IdPalabra, p.CodigoPalabra, p.PalabraEspanol";

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@espanol", espanol);

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (!lector.Read())
                        return null;

                    return new PalabraCompleta
                    {
                        IdPalabra = lector.GetInt32(0),
                        CodigoPalabra = lector.GetString(1),
                        PalabraEspanol = lector.GetString(2),
                        Ingles = lector.IsDBNull(3) ? "" : lector.GetString(3),
                        Frances = lector.IsDBNull(4) ? "" : lector.GetString(4),
                        Aleman = lector.IsDBNull(5) ? "" : lector.GetString(5)
                    };
                }
            }
        }
    }
}
