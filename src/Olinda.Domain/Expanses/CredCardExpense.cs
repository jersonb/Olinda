namespace Olinda.Domain.Expenses;

public class CredCardExpense : Entries
{
    public CredCardExpense(int portion, IEntry expense)
    {
        var value = expense.Value / portion;

        var date = expense.Date == default ? DateTime.UtcNow.Date : expense.Date;
        for (int i = 1; i <= portion; i++)
        {
            if (i != 1)
                date = date.AddMonths(1);

            var input = new EntryInput
            {
                Description = $"P{i} - {expense.Description}",
                Value = value,
                EntryFont = EntryFont.CredCard,
                Date = date
            };

            Add(ExpenseEntry.Create(input));
        }
    }
}