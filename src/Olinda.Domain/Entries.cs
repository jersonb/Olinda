using System.Collections;

namespace Olinda.Domain;

public class Entries : IEnumerable<Entry>
{
    private readonly List<Entry> entries;
    public int Count => entries.Count;

    public Entries()
        => entries = new();

    private Entries(IEnumerable<Entry> entries) : this()
        => AddRange(entries);

    private Entries(Entry entry) : this()
        => Add(entry);

    public static implicit operator Entries(Entry entry)
        => new(entry);

    public static implicit operator Entries(List<Entry> entries)
        => new(entries);

    public void Add(Entry entry)
    {
        if (entry.IsValid())
            entries.Add(entry);
    }

    public void AddRange(IEnumerable<Entry> entries)
        => this.entries.AddRange(entries.Where(e => e.IsValid()));

    public IEnumerator<Entry> GetEnumerator()
        => entries.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}