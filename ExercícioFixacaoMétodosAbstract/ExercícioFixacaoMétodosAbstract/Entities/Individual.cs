using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioFixacaoMétodosAbstract.Entities
{
    internal class Individual : TaxPayers
    {
        public double HealthExpenditure { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double healthExpenditure) : base(name, annualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double TaxPayment()
        {
            double payment = 0;
            if (AnnualIncome <= 20000)
            {
                if (HealthExpenditure != 0)
                {
                    payment = AnnualIncome * 0.15 - HealthExpenditure * 0.5;
                }
                else
                {
                    payment = AnnualIncome * 0.15;
                }
                
            }

            else
            {
                if (HealthExpenditure != 0)
                {
                    payment = AnnualIncome * 0.25 - HealthExpenditure * 0.5;
                }
                else
                {
                    payment = AnnualIncome * 0.15;
                }

            }

            return payment;
        }

        public override string ToString()
        {
            return $"{Name}: {TaxPayment().ToString("C")}";
        }
    }
}
