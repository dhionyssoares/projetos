using ExercícioOrder.Entities;
using ExercícioOrder.Entities.Enum;
using System;

namespace ExercícioOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            
            Client client = new Client(name, email, birthDate);
            
            DateTime moment = DateTime.Now;            
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus),Console.ReadLine());
            
            Order order = new Order(moment, status, client);
            
            Console.Write("How many items to this order: ");            
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                
                Product product = new Product(productName, price);
                
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                
                OrderItem item = new OrderItem(quantity, price, product);
                
                order.AddItem(item);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}