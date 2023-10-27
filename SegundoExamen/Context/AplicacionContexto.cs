using Microsoft.EntityFrameworkCore;
using SegundoExamen.Models;

namespace SegundoExamen.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Musica> Musica { get; set; }
        public DbSet<Disco> Disco { get; set; }


    }
}
