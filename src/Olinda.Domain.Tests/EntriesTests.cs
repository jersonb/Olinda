using Olinda.Domain.Expenses;
using Olinda.Domain.Incomes;
using Xunit;

namespace Olinda.Domain.Tests;
public class EntriesTests
{
    [Fact]
    public void Adding_invalid_should_count_zero()
    {
        Entries entries = new Entries
            {
                new ExpenseEntry(null, 0),
                new IncomeEntry(null, 0)
            };

        Assert.Equal(0, entries.Count);
    }

    [Fact]
    public void Adding_invalid_should_count_two()
    {
        var entries = new Entries
            {
                new ExpenseEntry("Teste", -1),
                new IncomeEntry("Teste", 1)
            };

        Assert.Equal(2, entries.Count);
    }
}
