#nullable disable

namespace Olinda.Domain
{
    public class ExpenseEntry : Entry
    {
        public ExpenseEntry(string description, decimal value, DateOnly? date = null) : base(description, value, date)
        {
        }
        
        public override bool IsValid()
            => Value < 0 && base.IsValid();
        
    }
}