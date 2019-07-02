using System;
using TaxCalculator.Application;
using TaxCalculator.Infrastructure.Models;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxation taxation = new Taxation();
            taxation.RunApplication();
        }
        
    }
}

