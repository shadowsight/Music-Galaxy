using Music_Galaxy.Models;
using Microsoft.EntityFrameworkCore;

namespace Music_Galaxy.Data
{
    public class MusicGalaxyContext : DbContext
    {
        public MusicGalaxyContext(DbContextOptions<MusicGalaxyContext> options) : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}