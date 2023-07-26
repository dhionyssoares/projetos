using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioFixacaoMétodosAbstract.Entities
{
    internal class Company : TaxPayers
    {

        public int EmployeeNumber { get; set; }

        public Company()
        {
        }

        public Company(string name, double annualIncome, int employeeNumber) : base(name, annualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double TaxPayment()
        {
            double payment = 0;
            if (EmployeeNumber > 10)
            {
                payment += AnnualIncome * 0.14;
            }
            else
            {
                payment += AnnualIncome * 0.16;
            
            }
            



            return payment;
        }

        public override string ToString()
        {
            return $"{Name}: {TaxPayment().ToString("C")}";
        }
    }
}
