using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Genero
    {
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }
        public PeliculaSerie PeliculaSerieAsociada { get; set; }

    }
}

