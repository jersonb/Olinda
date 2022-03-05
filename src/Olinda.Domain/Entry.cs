#nullable disable

namespace Olinda.Domain
{
    public abstract class Entry
    {
        protected Entry(string description, decimal value, DateOnly? date = null)
        {
            Description = description;
            Value = value;
            Date = date ?? DateOnly.FromDateTime(DateTime.UtcNow);
        }

        public string Description { get; }
        public decimal Value { get; }
        public DateOnly Date { get; }
        public virtual bool IsValid()
            => !string.IsNullOrEmpty(Description);
        
    }
}