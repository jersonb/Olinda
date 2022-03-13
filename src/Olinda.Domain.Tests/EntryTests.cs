using System;
using Xunit;

namespace Olinda.Domain.Tests;

public class EntryTests
{
    [Fact]
    public void Description_null_should_be_invalid()
    {
        var entry = DummyEntry.CreateInvalidWithDescriptionNull();
        Assert.False(entry.IsValid());
    }

    [Fact]
    public void Description_empty_should_be_invalid()
    {
        var entry = DummyEntry.CreateInvalidWithDescriptionEmpty();
        Assert.False(entry.IsValid());
    }

    [Fact]
    public void Value_zero_should_be_invalid()
    {
        var entry = DummyEntry.CreateInvalidWithValueZero();
        Assert.False(entry.IsValid());
    }

    [Fact]
    public void By_not_informing_date_it_should_be_today()
    {
        var entry = DummyEntry.CreateValidWithoutDate();
        Assert.Equal(DateTime.UtcNow.Day, entry.Date.Day);
        Assert.True(entry.IsValid());
    }

    [Fact]
    public void By_informing_date_it_should_be_date()
    {
        var date = DateTime.UtcNow.AddDays(3);
        var entry = DummyEntry.CreateValidWithDate(date);
        Assert.Equal(date.Day, entry.Date.Day);
        Assert.True(entry.IsValid());
    }

    [Fact]
    public void EntryFont_default_should_be_invalid()
    {
        var entry = DummyEntry.CreateInvalidWithEntryFontDefault();
        Assert.False(entry.IsValid());
    }

    [Fact]
    public void EntryFont_should_be_unique()
    {
        var fonts = Enum.GetValues<EntryFont>();
        for (int i = 0; i < fonts.Length; i++)
        {
            Assert.Equal(i, (int)fonts[i]);
        }
    }
}