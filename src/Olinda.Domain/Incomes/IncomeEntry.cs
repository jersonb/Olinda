namespace Olinda.Domain.Incomes;

public class IncomeEntry : Entry
{
    private IncomeEntry(IEntry entry) : base(entry)
    {
    }

    public static IncomeEntry Create(EntryInput entry)
    {
        return new IncomeEntry(entry);
    }

    public override bool IsValid()
        => Value > 0 && base.IsValid();
}
