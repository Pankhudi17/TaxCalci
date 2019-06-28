using System;
using TaxCalculator.Infrastructure.Models;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.RunApplication();
        }
        
    }
}

