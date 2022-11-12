
namespace fall_project_2;

public class User
{
    public string Name { get; }

    public string Email { get; }

    public List<Wallet> Wallets { get; }

    (String, String) login()
    {
        var email = Console.ReadLine();
        var password = Console.ReadLine();
        return (email, password);
    }
    
    (String, String, String) register()
    {
        var name = Console.ReadLine();
        var email = Console.ReadLine();
        var password = Console.ReadLine();

        return (name, email, password);
    }
}