using fall_project_2.Enums;

namespace fall_project_2;

public class Income : Operation
{
    public IncomeType Type { get; set; }

    public Income(Money value, DateTime date, IncomeType type) : base(value, date)
    {
        Type = type;
    }
}