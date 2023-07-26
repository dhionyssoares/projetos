using ExercícioFixacaoMétodosAbstract.Entities;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

List<TaxPayers> list = new List<TaxPayers>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char answer = char.Parse(Console.ReadLine());

    if (answer == 'i')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Annual income: ");
        double annualIncome = double.Parse(Console.ReadLine());
        Console.Write("Health expenditures: ");
        double healthExpenditure = double.Parse(Console.ReadLine());
        list.Add(new Individual(name, annualIncome, healthExpenditure));
    }
    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Annual income: ");
        double annualIncome = double.Parse(Console.ReadLine());
        Console.Write("Number of employees: ");
        int employeeNumber = int.Parse(Console.ReadLine());
        list.Add(new Company(name, annualIncome, employeeNumber));
    }
}


Console.WriteLine("\nTAXES PAID:\n");
double sum = 0;
foreach (TaxPayers item in list)
{
    Console.WriteLine(item.ToString());
    sum += item.TaxPayment();
}
Console.WriteLine($"\nTOTAL TAXES: {sum.ToString("C")}");
