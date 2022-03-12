namespace Olinda.Domain.Expenses;

public class ExpenseEntry : Entry
{

    private ExpenseEntry(IEntry entry) : base(entry)
    {
    }

    public static ExpenseEntry Create(EntryInput entry)
    {
        entry.Value = SetNegativeValue(entry.Value);

        return new ExpenseEntry(entry);
    }


    private static decimal SetNegativeValue(decimal value)
       => value > 0 ? value * -1 : value;

    public override bool IsValid()
        => Value < 0 && base.IsValid();

}
