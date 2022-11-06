
using fall_project_2.enums;

namespace fall_project_2;

public class Wallet
{
    public Wallet(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public Currency Currency { get; }

    public List<Operation> Operations { get; }

    public Money Amount { get; }

    // TODO Return type
    public void AddOperation(Income op) { }

    public void AddOperation(Expense op) { }

    public void CollectStatistic(DateTime from, DateTime to) { }
}