#nullable disable

namespace Olinda.Domain.Expenses
{
    public class CredCardExpense : Entries
    {
        public CredCardExpense(int portion, ExpenseEntry expense)
        {
            var value = expense.Value / portion;

            for (int i = 1; i <= portion; i++)
            {
                var date = expense.Date;

                if (i != 1)
                    date = date.AddMonths(1);

                Add(new ExpenseEntry($"P{i} - {expense.Description}", value, date));
            }
        }
    }
}