
namespace fall_project_2;

public class Wallet
{
    public Wallet(string name)
    {
        Name = name;
    }

    public string Name { get; }

    // TODO Return type
    public void AddOperation(Income op) { }

    public void AddOperation(Expense op) { }

    public void CollectStatistic(DateTime from, DateTime to) { }
}