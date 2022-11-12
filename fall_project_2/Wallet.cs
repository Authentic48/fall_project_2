
using fall_project_2.enums;

namespace fall_project_2;

public class Wallet
{
    public Wallet(string name, Currency currency, Money amount)
    {
        Name = name;
        Currency = currency;
        Amount = amount;
    }

    public string Name { get; }

    public Currency Currency { get; }

    public List<Operation> Operations { get; }

    public Money Amount { get; }

    public void AddOperation(Income operation)
    {
        Operations.Add(operation);
    }

    public void AddOperation(Expense operation)
    {
        Operations.Add(operation);
    }

    public void CollectStatistic(DateTime from, DateTime to) { }

    (String, String) createWallet()
    {
        var currency = Console.ReadLine();
        var amount = Console.ReadLine();

        return (currency, amount);
    }
    
    
    
}