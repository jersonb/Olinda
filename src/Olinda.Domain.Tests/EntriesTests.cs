using Olinda.Domain.Expenses;
using Olinda.Domain.Incomes;
using Xunit;

namespace Olinda.Domain.Tests;
public class EntriesTests
{
    [Fact]
    public void Adding_invalid_should_count_zero()
    {
        var input = new EntryInput
        {
            Value = 0,
            Description = null
        };
        var entries = new Entries
        {
             ExpenseEntry.Create(input),
             IncomeEntry.Create(input)
        };
        Assert.Equal(0, entries.Count);
    }

    [Fact]
    public void Adding_invalid_should_count_two()
    {
        var entries = new Entries
        {
            ExpenseEntry.Create(new EntryInput { Value = 1, Description = "Teste"}),
            IncomeEntry.Create(new EntryInput { Value = 1, Description = "Teste"})
        };

        Assert.Equal(2, entries.Count);
    }
}
