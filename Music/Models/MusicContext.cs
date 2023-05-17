using Microsoft.EntityFrameworkCore;

namespace Music.Models
{
    public class MusicContext : DbContext
    {
        public DbSet<Record> Records { get; set; }

        public MusicContext(DbContextOptions options) : base(options) { }
    }
}