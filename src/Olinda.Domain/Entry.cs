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
    {
        var descriptionOk = Description != null && Description.Length > 4;
        var valueOk = Value != 0;
        var entyFontOk = EntryFont != EntryFont.Default;
        return descriptionOk && valueOk && entyFontOk;
    }
}