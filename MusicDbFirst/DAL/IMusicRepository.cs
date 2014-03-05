using System;
using System.Linq;
using MusicDbFirst.Models;

namespace MusicDbFirst.DAL
{
    public interface IMusicRespository:IDisposable
    {
        IQueryable<Album> GetAllAlbums();
        IQueryable<Track> GetTracksForAlbum(int albumId);
    }
}
