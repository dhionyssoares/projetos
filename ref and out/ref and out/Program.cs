﻿using System.Collections.Generic;
using System.Security.Cryptography;
using ref_and_out;

Console.Write("how many employees will be registered? ");
int n = int.Parse(Console.ReadLine());
List<Employee> list = new List<Employee>();

for (int i = 1; i <= n; i++) {
    Console.WriteLine("Employee #" +  i);
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = (Console.ReadLine());
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());
    list.Add(new Employee(id, name, salary));
}

Console.Write("Enter the employee id that will have salary increase: ");
double increaseId = double.Parse(Console.ReadLine());
Employee emp = list.Find(x => x.Id == increaseId); {
    if (emp != null)
    {
        Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine());
        emp.Increase(percentage);
    }
}

Console.WriteLine("Updated list of employees:\n");

foreach (Employee obj in list)
{
    Console.WriteLine(obj);
}

