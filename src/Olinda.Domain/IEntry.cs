namespace Olinda.Domain
{
    public interface IEntry
    {
        EntryFont EntryFont { get; }
        string Description { get; }
        decimal Value { get; }
        DateTime Date { get; }
    }
}