using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class Collection
    {
        private static List<Collection> _instances = new List<Collection> {};
        public string CollectionName { get; set; }
        public int Id {get; }
        public List<Album> Album { get; set; }

        public Collection( string collectionName )
        {
            CollectionName = collectionName;
            _instances.Add(this);
            Id = _instances.Count;
            Album = new List<Album>{};
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Collection> GetAll()
        {
            return _instances;
        }

        public static Collection Find(int findId)
        {
            return _instances[findId - 1];
        }

        public void AddAlbum(Album album)
        {
            Album.Add(album);
        }
    }
}