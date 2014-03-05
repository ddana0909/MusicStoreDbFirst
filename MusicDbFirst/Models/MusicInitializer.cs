using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MusicDbFirst.Models
{
    public class MusicInitializer:DropCreateDatabaseAlways<MusicEntities>
    {
        protected override void Seed(MusicEntities db)
        {
            var album=new List<Album>
            {
               new Album{Name = "All the little lights", Artist = "Passenger",DateRelesed = new DateTime(2012,01,20),Price = 20,CoverPath = "~/Images/All-the-little-lights.jpg"},
               new Album{Name = "Nothing Else Matters", Artist = "Metallica",DateRelesed = new DateTime(2012,01,20),Price = 20,CoverPath = "~/Images/Nothing_Else_Matters.jpg"}           
            };

            album.ForEach(a=>db.Albums.Add(a));
            db.SaveChanges();

            var tracks = new List<Track>
            {
                new Track{Name = "Things That Stop You Dreaming" ,Duration = new TimeSpan(0,3,34),AlbumId = 1},
                new Track{Name = "Let Her Go" ,Duration = new TimeSpan(0,4,12),AlbumId = 1},
                new Track{Name = "Staring at the Stars" ,Duration = new TimeSpan(0,3,55),AlbumId = 1},
                new Track{Name = "The Wrong Direction" ,Duration = new TimeSpan(0,3,39),AlbumId = 1},
                new Track{Name = "Circles" ,Duration = new TimeSpan(0,3,09),AlbumId = 1},
                new Track{Name = "Keep on Walking" ,Duration = new TimeSpan(0,4,07),AlbumId = 1},
                new Track{Name = "Patient Love"  ,Duration = new TimeSpan(0,3,07),AlbumId = 1},
                new Track{Name = "Life's for the Living" ,Duration = new TimeSpan(0,4,33),AlbumId = 1},
                new Track{Name = "Holes" ,Duration = new TimeSpan(0,3,31),AlbumId = 1},
                new Track{Name = "Feather on the Clyde" ,Duration = new TimeSpan(0,4,01),AlbumId = 1},
                new Track{Name = "I Hate" ,Duration = new TimeSpan(0,3,30),AlbumId = 1},              
            };
            tracks.ForEach(t=>db.Tracks.Add(t));
            db.SaveChanges();

        }
    }
}
