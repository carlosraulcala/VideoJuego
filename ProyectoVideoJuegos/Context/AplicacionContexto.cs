using Microsoft.EntityFrameworkCore;
using ProyectoVideoJuegos.Models;

namespace ProyectoWebApp.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<VideoJuegos> VideoJuegos { get; set; }

    }
}