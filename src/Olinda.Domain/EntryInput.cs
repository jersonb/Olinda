#nullable disable

namespace Olinda.Domain;

public class EntryInput : IEntry
{
    public EntryFont EntryFont { get; set; }

    public string Description { get; set; }

    public decimal Value { get; set; }

    public DateTime Date { get; set; }
}