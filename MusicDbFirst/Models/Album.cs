using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicDbFirst.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        [DisplayName("Title")]
        public string Name { get; set; }
        public string Artist { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Relesed on:")]
        public DateTime DateRelesed { get; set; }
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public double Price { get; set; }
        public string CoverPath { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }

    }
}