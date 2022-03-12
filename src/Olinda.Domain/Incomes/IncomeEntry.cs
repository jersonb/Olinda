#nullable disable

namespace Olinda.Domain.Incomes
{
    public class IncomeEntry : Entry
    {
        public IncomeEntry(string description, decimal value, DateOnly? date = null) : base(description, value, date)
        {
        }
         public override bool IsValid()
            => Value > 0 && base.IsValid();
    }
}