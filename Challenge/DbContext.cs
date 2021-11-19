using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Challenge
{
    public class ChallengeDbContext : DbContext
    {
        public DbSet<Personaje> Personajes { get; set; }

        public DbSet<PeliculaSerie> PeliculasSeries { get; set; }

        public DbSet<Genero> Generos { get; set; }

    }
}
