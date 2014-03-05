using System.Linq;
using MusicDbFirst.Models;

namespace MusicDbFirst.DAL
{
    public class MusicRepository:IMusicRespository
    {
        public MusicEntities Entities;

        public MusicRepository()
        {
            Entities=new MusicEntities();
        }

        public void Dispose()
        {
            Entities.Dispose();
        }

        public IQueryable<Album> GetAllAlbums()
        {
            return Entities.Albums.OrderBy(a=>a.Artist);
        }

        public IQueryable<Track> GetTracksForAlbum(int albumId)
        {
            return Entities.Tracks.Where(t => t.AlbumId == albumId);
        }
    }
}