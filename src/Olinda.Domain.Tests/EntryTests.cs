#nullable disable

using System;
using Xunit;

namespace Olinda.Domain.Tests;

public class EntryTests
{
    [Fact]
    public void Description_null_should_be_invalid()
    {
        var income = new DummyEntry(null, 1);
        Assert.False(income.IsValid());
    }

    [Fact]
    public void Description_empty_should_be_invalid()
    {
        var income = new DummyEntry(string.Empty, 1);
        Assert.False(income.IsValid());
    }

    [Fact]
    public void Value_zero_should_be_invalid()
    {
        var income = new DummyEntry("Test", 0);
        Assert.False(income.IsValid());
    }

    [Fact]
    public void By_not_informing_date_it_should_be_today()
    {
        var income = new DummyEntry("Test", 1);
        Assert.Equal(DateTime.Now.Day, income.Date.Day);
    }

    [Fact]
    public void By_informing_date_it_should_be_date()
    {
        var date = DateTime.Now.AddDays(3);
        var income = new DummyEntry("Test", 1, date.Date);
        Assert.Equal(date.Day, income.Date.Day);
    }
}
