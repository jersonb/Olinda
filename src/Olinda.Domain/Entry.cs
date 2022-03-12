namespace Olinda.Domain;
public abstract class Entry
{
    protected Entry(string description, decimal value, DateTime? date = null)
    {
        Description = description;
        Value = value;
        date = date ?? DateTime.UtcNow;
        Date = date.Value.Date;
    }

    public string Description { get; }
    public decimal Value { get; }
    public DateTime Date { get; }
    public virtual bool IsValid()
        => !string.IsNullOrEmpty(Description) && Value != 0;

}
