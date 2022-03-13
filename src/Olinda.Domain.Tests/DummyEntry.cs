using System;

namespace Olinda.Domain.Tests;

public class DummyEntry : Entry
{
    private DummyEntry(IEntry entry) : base(entry)
    {
    }

    public static DummyEntry CreateValidWithDate()
    {
        var entry = new EntryInput
        {
            EntryFont = EntryFont.Pix,
            Description = "Teste",
            Value = 1,
            Date = DateTime.UtcNow.Date
        };

        return new DummyEntry(entry);
    }

    public static DummyEntry CreateValidWithDate(DateTime date)
    {
        var entry = new EntryInput
        {
            EntryFont = EntryFont.Pix,
            Description = "Teste",
            Value = 1,
            Date = date
        };

        return new DummyEntry(entry);
    }

    public static DummyEntry CreateValidWithoutDate()
    {
        var entry = new EntryInput
        {
            EntryFont = EntryFont.Pix,
            Description = "Teste",
            Value = 1,
            Date = default
        };

        return new DummyEntry(entry);
    }

    public static DummyEntry CreateInvalidWithEntryFontDefault()
    {
        var entry = new EntryInput
        {
            EntryFont = EntryFont.Default,
            Description = "Teste",
            Value = 1,
            Date = DateTime.UtcNow.Date
        };

        return new DummyEntry(entry);
    }

    internal static DummyEntry CreateInvalidWithDescriptionEmpty()
    {
        var entry = new EntryInput
        {
            EntryFont = EntryFont.Pix,
            Description = "",
            Value = 1,
            Date = DateTime.UtcNow.Date
        };

        return new DummyEntry(entry);
    }

    public static DummyEntry CreateInvalidWithDescriptionNull()
    {
        var entry = new EntryInput
        {
            EntryFont = EntryFont.Pix,
            Value = 1
        };

        return new DummyEntry(entry);
    }

    public static DummyEntry CreateInvalidWithValueZero()
    {
        var entry = new EntryInput
        {
            EntryFont = EntryFont.Pix,
            Description = "Teste",
            Value = 0,
            Date = DateTime.UtcNow.Date
        };

        return new DummyEntry(entry);
    }
}