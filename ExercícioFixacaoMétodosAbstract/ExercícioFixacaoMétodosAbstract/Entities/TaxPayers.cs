using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioFixacaoMétodosAbstract.Entities
{
    internal abstract class TaxPayers
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayers()
        {
        }

        public TaxPayers(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TaxPayment();

        public abstract string ToString();
        
    }
}
