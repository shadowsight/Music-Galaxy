using System;
using System.ComponentModel.DataAnnotations;

namespace Music_Galaxy.Models
{
    public class Song
    {
        public int ID { get; set; }

        [Required]
        public String Title { get; set; }

        public int AlbumID { get; set; }

        public Album Album { get; set; }
    }
}