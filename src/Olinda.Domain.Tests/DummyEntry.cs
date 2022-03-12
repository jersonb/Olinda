namespace Olinda.Domain.Tests;

public class DummyEntry : Entry
{
    private DummyEntry(IEntry entry) : base(entry)
    {
    }

    public static DummyEntry Create(EntryInput entry)
    {
        entry.EntryFont = EntryFont.Pix;
        return new DummyEntry(entry);
    }
}