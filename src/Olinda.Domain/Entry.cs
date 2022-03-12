namespace Olinda.Domain;

public abstract class Entry : IEntry
{
    protected Entry(IEntry entry)
    {
        Description = entry.Description;
        Value = entry.Value;
        var date = entry.Date == default ? DateTime.UtcNow.Date : entry.Date.Date;
        Date = date;
        EntryFont = entry.EntryFont;
    }

    public EntryFont EntryFont { get; }
    public string Description { get; }
    public decimal Value { get; }
    public DateTime Date { get; }

    public virtual bool IsValid()
        => Description != null && Description.Length > 4 && Value != 0;
}