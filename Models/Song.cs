using System;
using System.ComponentModel.DataAnnotations;

namespace Music_Galaxy.Models
{
    public class Song
    {
        public int ID { get; set; }
        public String Title { get; set; }

        public int AlbumID { get; set; }

        public int ArtistID { get; set; }

        public Artist Artist { get; set; }

        public Album Album { get; set; }
    }
}