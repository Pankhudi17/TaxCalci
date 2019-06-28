using System;
using TaxCalculator.Implementation;
using TaxCalculator.Infrastructure.Interfaces;
using TaxCalculator.Infrastructure.Models;

namespace TaxCalculator
{
    public class Calculator
    {

        Account account = new Account();

        Tax tax = new Tax();
        

        public void RunApplication()
        {
            AcceptInput();
            Process();
            DisplayOutput();
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
        public void Process()
        {
            var taxableIncome = this._account.GetTaxableIncome(account.Bonus, account.AnnualSalary, account.EightyC_Deduction);
            Console.WriteLine("Taxable Income "+ taxableIncome);
            var totalTax = this._account.GetTotalTax(account.Age, account.Gender, taxableIncome);
            Console.WriteLine("Total Tax " + totalTax);
            Console.ReadKey();
        }
        public void DisplayOutput()
        {
         
        }
    }
}
