using ExercícioExcecoes.Entities;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withDrawLimit = double.Parse(Console.ReadLine());

    Account account = new Account(number, holder, balance, withDrawLimit);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine());
    account.Withdraw(amount);

    Console.Write($"New balance: {account.Balance.ToString("C")}");
}

catch (DomainExceptions e)
{
    Console.WriteLine($"Error in Withdraw: {e.Message}");
}