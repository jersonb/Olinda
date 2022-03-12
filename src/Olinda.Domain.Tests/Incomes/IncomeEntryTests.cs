using Olinda.Domain.Incomes;
using Xunit;

namespace Olinda.Domain.Tests
{
    public class IncomeEntryTests
    {

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