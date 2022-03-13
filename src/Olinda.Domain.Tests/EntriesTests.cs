using Xunit;

namespace Olinda.Domain.Tests;

public class EntriesTests
{
    [Fact]
    public void Adding_invalid_should_count_zero()
    {
        var entries = new Entries
        {
            DummyEntry.CreateInvalidWithDescriptionNull(),
            DummyEntry.CreateInvalidWithDescriptionEmpty()
        };
        Assert.Equal(0, entries.Count);
    }

    [Fact]
    public void Adding_valid_should_count_two()
    {
        var entries = new Entries
        {
            DummyEntry.CreateValidWithDate(),
            DummyEntry.CreateValidWithDate()
        };

        Assert.Equal(2, entries.Count);
    }
}