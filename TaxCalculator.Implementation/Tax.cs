using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Infrastructure.Interfaces;

namespace TaxCalculator.Implementation
{
    public class Tax : IAccount
    {
        public Tax()
        {

        }
        public double GetTaxableIncome(double bonus, double annualSalary, double eightyC_Deduction)
        {
            return (bonus + annualSalary) - eightyC_Deduction;
        }

        public double GetTotalTax(int age, string gender, double taxableIncome)
        {
            return (taxableIncome * 10) / 100;
        }
    }
}
