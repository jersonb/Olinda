#nullable disable

namespace Olinda.Domain
{
    public class CredCardExpense
    {
        public Entries Entries { get; }

        public CredCardExpense(int portion, ExpenseEntry expense)
        {
            Entries = new();
            var value = expense.Value / portion;

            for (int i = 1; i <= portion; i++)
            {
                var date = expense.Date;

                if (i != 1)
                    date = date.AddMonths(1);

                Entries.Add(new ExpenseEntry($"P{i} - {expense.Description}", value, date));
            }
        }
    }
}