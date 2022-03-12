using Olinda.Domain.Incomes;
using Xunit;

namespace Olinda.Domain.Tests
{
    public class IncomeEntryTest
    {
         [Fact]
        public void Description_null_should_be_invalid()
        {
            var income = new IncomeEntry(null, 1);
            Assert.False(income.IsValid());
        }
        
        [Fact]
        public void Description_empty_should_be_invalid()
        {
            var income = new IncomeEntry(string.Empty, 1);
            Assert.False(income.IsValid());
        }

        [Fact]
        public void Negative_value_shold_be_invalid()
        {
            var income = new IncomeEntry("Teste", -1);
            Assert.False(income.IsValid());
        }

        [Fact]
        public void Zero_value_shold_be_invalid()
        {
            var income = new IncomeEntry("Teste", 0);
            Assert.False(income.IsValid());
        }

        [Fact]
        public void Shold_be_valid()
        {
            var income = new IncomeEntry("Teste", 1);
            Assert.True(income.IsValid());
        }
    }
}