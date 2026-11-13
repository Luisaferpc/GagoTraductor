using System;
using System.Collections.Generic;
using System.Text;

namespace Gago.Library.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int Rol { get; set; }
    }
}
