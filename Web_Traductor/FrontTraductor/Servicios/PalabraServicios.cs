using System.Net.Http.Json;

namespace FrontTraductor.Servicios
{
    public class PalabraServicios
    {
        private readonly HttpClient _http;

        public PalabraServicios(HttpClient http)
        {
            _http = http;
        }

        //Consultar una palabra
        public async Task<PalabraDto?> ObtenerPorEspanolAsync(string texto)
        {
            
            return await _http.GetFromJsonAsync<PalabraDto>($"api/Palabras/espanol/{texto}");
        }
        //Consultar una palabra por código
        public async Task<PalabraDto?> ObtenerPorCodigoAsync(string codigo)
        {
            try
            {
                return await _http.GetFromJsonAsync<PalabraDto>($"api/Palabras/codigo/{codigo}");
            }
            catch
            {
                return null;
            }
        }

        // Registrar una nueva palabra base
        public async Task<bool> RegistrarPalabraAsync(object nuevaPalabra)
        {
            var response = await _http.PostAsJsonAsync("api/Palabras", nuevaPalabra);
            return response.IsSuccessStatusCode;
        }

        // Consulta la traducción enviando la palabra y la abreviación del idioma por QueryString
        public async Task<ResultadoTraduccionDto?> ObtenerTraduccionAsync(string palabra, string idioma)
        {
            try
            {
                return await _http.GetFromJsonAsync<ResultadoTraduccionDto>($"api/Traducciones/traducir?palabra={Uri.EscapeDataString(palabra)}&idioma={Uri.EscapeDataString(idioma)}");
            }
            catch
            {
                return null;
            }
        }
    }

    // Espejo exacto de la entidad Palabra del backend
    public class PalabraDto
    {
        public int IdPalabra { get; set; }
        public string PalabraEspanol { get; set; }
        public string CodigoPalabra { get; set; }
    }

    // Espejo exacto de la entidad Traduccion del backend
    public class TraduccionDto
    {
        public int IdTraduccion { get; set; }
        public int PalabraId { get; set; }
        public int IdiomaId { get; set; }
        public string TextoTraduccion { get; set; }
    }

    // Espejo exacto de la entidad Idioma del backend
    public class IdiomaDto
    {
        public int IdIdioma { get; set; }
        public string Abreviacion { get; set; } // Ej: ES, FR, IN
        public string NombreIdioma { get; set; }
    }

    public class ResultadoTraduccionDto
    {
        public string PalabraEspanol { get; set; }
        public string Idioma { get; set; }
        public string Traduccion { get; set; }
    }
}

