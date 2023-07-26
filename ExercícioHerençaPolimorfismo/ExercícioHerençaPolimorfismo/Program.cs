using ExercícioHerençaPolimorfismo.Entities;
using System.Collections.Generic;

List<Employee> list = new List<Employee>();
Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data: ");
    Console.Write("Outsourced (y/n)? ");
    char answer = char.Parse(Console.ReadLine());

    if (answer == 'n')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value Per Hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());
        list.Add(new Employee(name, hours, valuePerHour));

    }
    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value Per Hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine());
        list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));

    }



}
Console.WriteLine("\nPayment: ");
    foreach (Employee item in list)
{
    Console.WriteLine(item.Name + " - " + item.Payment().ToString("C"));
}

