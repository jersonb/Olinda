namespace Olinda.Domain.Expenses;

public class ExpenseEntry : Entry
{

    public ExpenseEntry(string description, decimal value, DateTime? date = null) : base(description, SetNegativeValue(value), date)
    {
    }

    private static decimal SetNegativeValue(decimal value)
       => value > 0 ? value * -1 : value;

    public override bool IsValid()
        => Value < 0 && base.IsValid();

}
