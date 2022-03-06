using Xunit;

namespace Olinda.Domain.Tests
{
    public class ExpenseEntryTest
    {
        [Fact]
        public void Description_null_should_be_invalid()
        {
            var expanse = new ExpenseEntry(null, -1);
            Assert.False(expanse.IsValid());
        }
        
        [Fact]
        public void Description_empty_should_be_invalid()
        {
            var expanse = new ExpenseEntry(string.Empty, -1);
            Assert.False(expanse.IsValid());
        }

        [Fact]
        public void Positive_value_converted_to_negative()
        {
            var expanse = new ExpenseEntry("Teste", 1);
            Assert.True(expanse.IsValid());
            Assert.Equal(-1, expanse.Value);
        }

        [Fact]
        public void Zero_value_shold_be_invalid()
        {
            var expanse = new ExpenseEntry("Teste", 0);
            Assert.False(expanse.IsValid());
        }

        [Fact]
        public void Shold_be_valid()
        {
            var expanse = new ExpenseEntry("Teste", -1);
            Assert.True(expanse.IsValid());
        }
    }
}