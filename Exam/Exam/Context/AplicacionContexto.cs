using Microsoft.EntityFrameworkCore;
using MusicModel;
using DiskModel;

namespace AppContext
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Diskk> Disk { get; set; }
        public DbSet<Music> Music { get; set; }
    }
}
