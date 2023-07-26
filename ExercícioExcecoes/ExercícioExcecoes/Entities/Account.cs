using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioExcecoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {            
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                if (amount > Balance)
                {
                    throw new DomainExceptions("Amount is out of withdraw limit and not enough balance.");
                }

                throw new DomainExceptions("Amount is out of withdraw limit.");
            }
            else if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance.");
            }
          
            Balance = Balance - amount;
        }
    }
}
