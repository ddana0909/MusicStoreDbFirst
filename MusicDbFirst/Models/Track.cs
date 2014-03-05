using System;
using System.ComponentModel.DataAnnotations;

namespace MusicDbFirst.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        
        [DisplayFormat(DataFormatString = @"{0:mm\:ss}")]
        public TimeSpan Duration { get; set; }
        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}