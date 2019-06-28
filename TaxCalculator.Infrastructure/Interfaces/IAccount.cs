using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Infrastructure.Interfaces
{
    public interface IAccount
    {
       double GetTaxableIncome(double bonus, double annualSalary, double eightyC_Deduction);
       double GetTotalTax(int age, string gender, double taxableIncome);
    }
}
