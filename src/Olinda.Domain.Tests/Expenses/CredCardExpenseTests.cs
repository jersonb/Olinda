using System;
using System.Linq;
using Olinda.Domain.Expenses;
using Xunit;

namespace Olinda.Domain.Tests;

public class CredCardExpenseTests
{
    [Fact]
    public void Portion_count_should_be_ten()
    {
        var credCardExpense = new CredCardExpense(10, new ExpenseEntry("teste", 100));

        Assert.Equal(10, credCardExpense.Count);
    }

    [Fact]
    public void Portion_value_should_be_ten()
    {
        var credCardExpense = new CredCardExpense(10, new ExpenseEntry("teste", 100));

        Assert.Equal(-10, credCardExpense.ElementAt(0).Value);
    }


    [Fact]
    public void Portion_month_should_be_subsequent()
    {
        var credCardExpense = new CredCardExpense(10, new ExpenseEntry("teste", 100));

        Assert.Equal(DateTime.UtcNow.Month, credCardExpense.ElementAt(0).Date.Month);
        Assert.Equal(DateTime.UtcNow.Month + 1, credCardExpense.ElementAt(1).Date.Month);
    }

    [Fact]
    public void Portion_description_should_be_incremented()
    {
        var credCardExpense = new CredCardExpense(10, new ExpenseEntry("teste", 100));

        Assert.Equal("P1 - teste", credCardExpense.ElementAt(0).Description);
        Assert.Equal("P2 - teste", credCardExpense.ElementAt(1).Description);
    }
}
