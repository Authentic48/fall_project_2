using fall_project_2.enums;

namespace fall_project_2;

public class Expense : Operation
{
    public ExpenseType Type;


    public Expense(Money value, DateTime date) : base(value, date)
    {
    }
}