using System.Collections.Generic;

public class Artist
{
    private static List<Artist> _instances = new List<Artist>();

    public Artist()
    {
        this.Records = new List<Record>();
        _instances.Add(this);
    }

    public int ArtistId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Record> Records { get; set; }

    public static List<Artist> GetAll()
    {
        return _instances;
    }

    public static void ClearAll()
    {
        _instances.Clear();
    }
}
