using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class Album
    {
        public string AlbumName { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Id { get; set; }
        private static List<Album> _instances = new List<Album> { };

        public Album(string albumName, string artist, string genre)
        {
            AlbumName = albumName;
            Artist = artist;
            
        }
    
    }
}