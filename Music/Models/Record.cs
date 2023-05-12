using System.Collections.Generic;

namespace Music.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        private static List<Record> _instances = new List<Record> { };

        public Record(string title, Artist artist)
        {
            Title = title;
            Artist = artist;
            _instances.Add(this);
            RecordId = _instances.Count;
        }

        public static List<Record> GetAll()
        {
            return _instances;
        }

        public static Record Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }

}
