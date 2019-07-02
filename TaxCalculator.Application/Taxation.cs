using System;
using TaxCalculator.Implementation;
using TaxCalculator.Infrastructure.Interfaces;
using TaxCalculator.Infrastructure.Models;

namespace TaxCalculator.Application
{
    public class Taxation
    {
        
        Calculator calculator = new Calculator();

        public void RunApplication()
        {
            calculator.AcceptInput();
            calculator.DisplayOutput();
        }
    }
}
