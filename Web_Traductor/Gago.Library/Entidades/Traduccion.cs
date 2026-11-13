using System;
using System.Collections.Generic;
using System.Text;

namespace Gago.Library.Entidades
{
    public class Traduccion
    {
        public int IdTraduccion { get; set; }
        public int PalabraId { get; set; }
        public int IdiomaId { get; set; }
        public string TextoTraduccion { get; set; }
    }
}
