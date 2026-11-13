using Gago.Library.Datos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackTraductor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraduccionesController : ControllerBase
    {
        private readonly NuevaTraduccion _daoTraduccion = new NuevaTraduccion();

        // 1. Obtener traducción por palabra en español y abreviación de idioma
        [HttpGet("traducir")]
        public IActionResult ObtenerTraduccion([FromQuery] string palabra, [FromQuery] string idioma)
        {
            string traduccion = _daoTraduccion.ObtenerTraduccion(palabra, idioma);

            if (string.IsNullOrEmpty(traduccion))
            {
                return NotFound(new { mensaje = "No se encontró traducción para los parámetros indicados." });
            }

            return Ok(new { palabraEspanol = palabra, idioma = idioma, traduccion = traduccion });
        }

        // 2. Insertar una nueva traducción
        [HttpPost]
        public IActionResult InsertarTraduccion([FromBody] TraduccionRequest request)
        {
            bool resultado = _daoTraduccion.InsertarTraduccion(request.PalabraId, request.IdiomaId, request.TextoTraduccion);

            if (resultado)
            {
                return Ok(new { mensaje = "Traducción registrada con éxito." });
            }

            return BadRequest(new { mensaje = "No se pudo registrar la traducción." });
        }
    }

    // Modelo auxiliar para recibir los datos en las peticiones POST
    public class TraduccionRequest
    {
        public int PalabraId { get; set; }
        public int IdiomaId { get; set; }
        public string TextoTraduccion { get; set; }
    }
}

