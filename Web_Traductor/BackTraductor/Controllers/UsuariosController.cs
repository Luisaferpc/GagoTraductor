using Gago.Library.Datos;
using Gago.Library.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackTraductor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly NuevoUsuario _daoUsuario = new NuevoUsuario();

        // Endpoint para validar el inicio de sesión (Ej: /api/Usuarios/login)
        [HttpPost("login")]
        public IActionResult ValidarLogin([FromBody] LoginRequest request)
        {
            Usuario usuario = _daoUsuario.ValidarLogin(request.NombreUsuario, request.Clave);

            if (usuario == null)
            {
                return Unauthorized(new { mensaje = "Credenciales incorrectas o usuario no encontrado." });
            }

            // Si el login es exitoso, devolvemos los datos del usuario (puedes omitir la clave por seguridad si lo deseas)
            return Ok(new
            {
                mensaje = "Inicio de sesión exitoso",
                usuario = new
                {
                    usuario.IdUsuario,
                    usuario.NombreUsuario,
                    usuario.Rol
                }
            });
        }
    }

    // Modelo auxiliar para recibir las credenciales en el cuerpo de la petición POST
    public class LoginRequest
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
    }
}

