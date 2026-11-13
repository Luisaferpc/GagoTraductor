using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gago.Library.Datos;
using Gago.Library.Entidades;
using Microsoft.AspNetCore.Mvc;
using Gago.Library.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using Gago.Library.Entidades; // Asegúrate de tener este using hacia tu librería

namespace BackTraductor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalabrasController : ControllerBase
    {
        private readonly NuevaPalabra _daoPalabra = new NuevaPalabra();

        // 1. Insertar una nueva palabra con sus traducciones usando PalabraCompleta
        [HttpPost]
        public IActionResult Insertar([FromBody] PalabraCompleta request)
        {
            try
            {
                // Usamos la misma clase y método que la consola para que guarde todo igual
                GestionPalabras gestor = new GestionPalabras();
                string codigoGenerado = gestor.Registrar(
                    request.PalabraEspanol,
                    request.Ingles,
                    request.Frances,
                    request.Aleman
                );

                if (!string.IsNullOrEmpty(codigoGenerado))
                {
                    return Ok(new { mensaje = "Palabra y traducciones registradas con éxito.", codigo = codigoGenerado });
                }
                return BadRequest(new { mensaje = "No se pudo registrar la palabra." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = $"Error interno: {ex.Message}" });
            }
        }

        // 2. Buscar por Código
        [HttpGet("codigo/{codigo}")]
        public IActionResult BuscarPorCodigo(string codigo)
        {
            var palabra = _daoPalabra.BuscarPorCodigo(codigo);
            if (palabra == null)
            {
                return NotFound(new { mensaje = "Palabra no encontrada por código." });
            }
            return Ok(palabra);
        }

        // 3. Buscar por texto en Español
        [HttpGet("espanol/{texto}")]
        public IActionResult BuscarPorEspanol(string texto)
        {
            GestionPalabras gestor = new GestionPalabras();
            var palabra = gestor.BuscarCompletaPorEspanol(texto);

            if (palabra == null)
            {
                return NotFound(new { mensaje = "Palabra no encontrada en español." });
            }

            // Devolvemos un objeto anónimo explícito para que Blazor lo reciba sin enredos de mayúsculas
            return Ok(new
            {
                idPalabra = palabra.IdPalabra,
                codigoPalabra = palabra.CodigoPalabra,
                palabraEspanol = palabra.PalabraEspanol,
                ingles = palabra.Ingles,
                frances = palabra.Frances,
                aleman = palabra.Aleman
            });
        }

        // 4. Actualizar palabra y sus traducciones
        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] PalabraCompleta request)
        {
            try
            {
                GestionPalabras gestor = new GestionPalabras();

                // Asignamos el ID que viene en la ruta por seguridad
                request.IdPalabra = id;

                // Como Modificar es void, simplemente lo ejecutamos
                gestor.Modificar(request);

                // Si llegó hasta aquí sin excepciones, todo salió bien
                return Ok(new { mensaje = "Palabra actualizada correctamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = $"Error interno: {ex.Message}" });
            }
        }

        // 5. Eliminar palabra
        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            try
            {
                GestionPalabras gestor = new GestionPalabras();
                bool resultado = gestor.Eliminar(id); // Recibe el ID y retorna bool

                if (resultado)
                {
                    return Ok(new { mensaje = "Palabra eliminada correctamente." });
                }
                return NotFound(new { mensaje = "No se pudo eliminar la palabra." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = $"Error interno: {ex.Message}" });
            }
        }

        // 6. Endpoint de Login para validar credenciales desde la Web
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestModel model)
        {
            try
            {
                NuevoUsuario datosUsuario = new NuevoUsuario();
                Usuario usuario = datosUsuario.ValidarLogin(model.Usuario, model.Clave);

                if (usuario == null)
                {
                    return Unauthorized(new { mensaje = "Usuario o contraseña incorrectos." });
                }

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = ex.Message });
            }
        }
    }

    // Modelo auxiliar únicamente para el Login (las palabras usan PalabraCompleta de Gago.Library)
    public class LoginRequestModel
    {
        public string Usuario { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
    }
}