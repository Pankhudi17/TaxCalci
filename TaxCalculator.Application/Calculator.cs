using System;
using TaxCalculator.Implementation;
using TaxCalculator.Infrastructure.Interfaces;
using TaxCalculator.Infrastructure.Models;

namespace TaxCalculator.Application
{
    public class Calculator
    {
        protected readonly ITax _tax;
        Tax tax = new Tax();
        Account account = new Account();
        public Calculator()
        {
            this._tax = tax;
        }
        public void AcceptInput()
        {
            Console.WriteLine("Tax Calculator");
            Console.WriteLine("Enter Annual Salary :");

            account.AnnualSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Bonus :");
            account.Bonus = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Age :");
            account.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender :");
            account.Gender = Console.ReadLine();

            Console.WriteLine("Enter Deduction :");
            account.EightyC_Deduction = Convert.ToDouble(Console.ReadLine());

        }

        public void DisplayOutput()
        {
            var taxableIncome = this._tax.GetTaxableIncome(account.Bonus, account.AnnualSalary, account.EightyC_Deduction);
            Console.WriteLine("Taxable Income " + taxableIncome);
            var totalTax = this._tax.GetTotalTax(account.Age, account.Gender, taxableIncome);
            Console.WriteLine("Total Tax " + totalTax);
            Console.ReadKey();
        }

    }
}
