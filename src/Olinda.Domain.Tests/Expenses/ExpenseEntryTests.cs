using Olinda.Domain.Expenses;
using Xunit;

namespace Olinda.Domain.Tests
{
    public class ExpenseEntryTests
    {
        [Fact]
        public void Positive_value_converted_to_negative()
        {
            var input = new EntryInput
            {
                Value = 1,
                Description = "Teste"
            };

            var expanse = ExpenseEntry.Create(input);
            Assert.True(expanse.IsValid());
            Assert.Equal(-1, expanse.Value);
        }

        [Fact]
        public void Zero_value_shold_be_invalid()
        {
            var input = new EntryInput
            {
                Value = 0,
                Description = "Teste"
            };

            var expanse = ExpenseEntry.Create(input);
            Assert.False(expanse.IsValid());
        }

        [Fact]
        public void Shold_be_valid()
        {
            var input = new EntryInput
            {
                Value = -1,
                Description = "Teste"
            };

            var expanse = ExpenseEntry.Create(input);
            Assert.True(expanse.IsValid());
        }
    }
}