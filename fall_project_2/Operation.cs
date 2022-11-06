namespace fall_project_2;

public abstract class Operation
{
    public DateTime Date { get; }

    public Money Value { get; }

    public Operation(Money value, DateTime date)
    {
        Value = value;
        Date = date;
    }
}