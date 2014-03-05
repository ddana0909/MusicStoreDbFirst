using System.Data.Entity;

namespace MusicDbFirst.Models
{
    public class MusicEntities:DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public MusicEntities()
            : base("MusicDatabase")
        {
            Database.SetInitializer(new MusicInitializer());
        }
    }
}