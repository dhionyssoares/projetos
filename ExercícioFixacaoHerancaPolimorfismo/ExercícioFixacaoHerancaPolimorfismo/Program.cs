using ExercícioFixacaoHerancaPolimorfismo.Entities;

List<Product> products = new List<Product>();
Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i) ? ");
    char anwser = char.Parse( Console.ReadLine());
    if (anwser == 'i')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse( Console.ReadLine());
        Console.Write("Customs fee: ");
        double customsFee = double.Parse( Console.ReadLine());
        products.Add(new ImportedProduct(name, price, customsFee));
    }
    else if (anwser == 'u')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse( Console.ReadLine());
        products.Add(new UsedProduct(name, price, manufactureDate));
    }
    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        products.Add(new Product(name, price));
    }
}

Console.WriteLine("\nPRICE TAGS:");
foreach (Product item in products)
{
    Console.WriteLine(item.PriceTag());
}