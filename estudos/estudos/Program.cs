using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {


            Console.Write("Entre com o número da conta:");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o títular da conta:");
            string titular = (Console.ReadLine());
            Console.Write("Haverá depósito inicial (s/n)?");
            string respostaDepósito = (Console.ReadLine());


            ContaBancária n = new ContaBancária(conta, titular);

            if (respostaDepósito == "s" || respostaDepósito == "S") {
                Console.Write("Entre com o valor de depósito inicial:");
                double valorDepósito = double.Parse((Console.ReadLine()));
                n.Depositar(valorDepósito);
                Console.WriteLine("Dados da conta: \n" + n);
            }

            else {
                Console.WriteLine("Dados da conta: \n" + n);
            }
            Console.WriteLine("Gostaria de realizar um saque?(s/n)");
            string respostaSaque = (Console.ReadLine());
            if (respostaSaque == "s" || respostaSaque == "S")
            {
                Console.Write("entre com um valor para saque:");
                double saque = double.Parse((Console.ReadLine()));
                n.Sacar(saque);
                Console.WriteLine("dados atualizados:\n" + n);
            }
            else { Console.WriteLine("Dados da conta: \n" + n); }
            
        }
    }
}
