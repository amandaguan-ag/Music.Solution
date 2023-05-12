using System.Collections.Generic;

public class Record
{
    private static List<Record> _instances = new List<Record>();

    public Record()
    {
        _instances.Add(this);
    }

    public int RecordId { get; set; }
    public string Title { get; set; }

    public int ArtistId { get; set; }
    public virtual Artist Artist { get; set; }

    public static List<Record> GetAll()
    {
        return _instances;
    }

    public static void ClearAll()
    {
        _instances.Clear();
    }
}
