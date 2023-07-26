using System;


namespace Treinos {

    internal class Program {
        static void Main(string[] args) {
                        
            Estudante[] quartos = new Estudante [10];
            Console.WriteLine("how many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("\n\nRent #" + i + ": ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                quartos[room] = new Estudante(name, email);
            }
            Console.WriteLine("\nbusy rooms:\n");

            for (int i = 0;i < quartos.Length; i++) {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i].Name + ", " + quartos[i].Email);
                }
            }
            

        }
    }
}