Console.Clear();
Console.WriteLine("Welcome to your personal finance console app");
Console.WriteLine("Choose an option");
Console.WriteLine("[1] register");
Console.WriteLine("[2] login");
Console.WriteLine("[3] exit");
Console.Write("\r\nSelect an option: ");

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("This is the register option");
        Register();
        break;
    case "2":
        Console.WriteLine("This is the login option");
        Login();
        break;
    case "3":
        Console.WriteLine("GoodBye!");
        break;
}

static (String currency, String amount) CreateWallet()
{
    Console.Write("PLease choose currency");
    var currency = Console.ReadLine();
    Console.Write("PLease enter your amount");
    var amount = Console.ReadLine();

    return (currency, amount);
}

static (String email, String password) Login()
{
    Console.Write("PLease enter your email");
    var email = Console.ReadLine();
    Console.Write("PLease enter your password");
    var password = ReadPassword();
    return (email, password);
}

static (String name, String email, String password) Register()
{
    Console.Write("PLease enter your name");
    var name = Console.ReadLine();
    Console.Write("PLease enter your email");
    var email = Console.ReadLine();
    Console.Write("PLease enter your password");
    var password = ReadPassword();

    return (name, email, password);
}

// Helper to read masked password
static string ReadPassword()
{
    var value = new List<char>();
    while (true)
    {
        var key = Console.ReadKey(true);
        Console.Write('*');

        if (key.Key == ConsoleKey.Enter)
        {
            break;
        }

        value.Add(key.KeyChar);
    }

    return new String(value.ToArray());
}

static (String amount, String date, String category) AddOperation () {
    Console.Write("PLease enter your amount");
    var amount = Console.ReadLine();
    Console.Write("PLease enter your date");
    var date = Console.ReadLine();
    Console.Write("Choose your category");
    var category = Console.ReadLine();

    return (amount, date, category);
} 

static String ChooseWallet () {
    Console.Write("PLease enter your wallet name");
    var name = Console.ReadLine();

    return name;
}