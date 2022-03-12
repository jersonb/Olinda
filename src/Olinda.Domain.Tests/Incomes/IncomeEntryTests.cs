using Olinda.Domain.Incomes;
using Xunit;

namespace Olinda.Domain.Tests;
public class IncomeEntryTests
{

    [Fact]
    public void Negative_value_shold_be_invalid()
    {
        var input = new EntryInput
        {
            Value = -1,
            Description = "Teste"
        };

        var income = IncomeEntry.Create(input);
        Assert.False(income.IsValid());
    }

    [Fact]
    public void Zero_value_shold_be_invalid()
    {
        var input = new EntryInput
        {
            Value = 0,
            Description = "Teste"
        };

        var income = IncomeEntry.Create(input);
        Assert.False(income.IsValid());
    }

    [Fact]
    public void Shold_be_valid()
    {
        var input = new EntryInput
        {
            Value = 1,
            Description = "Teste"
        };

        var income = IncomeEntry.Create(input);
        Assert.True(income.IsValid());
    }
}