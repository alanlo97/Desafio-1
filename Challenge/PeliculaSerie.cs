using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class PeliculaSerie
    {
        public string Url { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int Calificaion { get; set; }
        public Personaje PersonajesAsociados { get; set; }

    }
}
