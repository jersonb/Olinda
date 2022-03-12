using System;
using Xunit;

namespace Olinda.Domain.Tests;

public class EntryTests
{
    [Fact]
    public void Description_null_should_be_invalid()
    {
        var entry = DummyEntry.Create(new EntryInput());
        Assert.False(entry.IsValid());
    }

    [Fact]
    public void Description_empty_should_be_invalid()
    {
        var input = new EntryInput { Value = 1 };
        var entry = DummyEntry.Create(input);
        Assert.False(entry.IsValid());
    }

    [Fact]
    public void Value_zero_should_be_invalid()
    {
        var input = new EntryInput
        {
            Value = 0,
            Description = "Teste"
        };
        var entry = DummyEntry.Create(input);
        Assert.False(entry.IsValid());
    }

    [Fact]
    public void By_not_informing_date_it_should_be_today()
    {
        var input = new EntryInput
        {
            Value = 1,
            Description = "Teste"
        };
        var entry = DummyEntry.Create(input);
        Assert.Equal(DateTime.Now.Day, entry.Date.Day);
    }

    [Fact]
    public void By_informing_date_it_should_be_date()
    {
        var date = DateTime.Now.AddDays(3);
        var input = new EntryInput
        {
            Value = 1,
            Description = "Teste",
            Date = date
        };
        var entry = DummyEntry.Create(input);
        Assert.Equal(date.Day, entry.Date.Day);
    }

    [Fact]
    public void TestName()
    {
        var input = new EntryInput
        {
            Value = 1,
            Description = "Teste"
        };
        var entry = DummyEntry.Create(input);
        var expected = entry.EntryFont;
        Assert.Equal(0, (int)expected);
    }
}