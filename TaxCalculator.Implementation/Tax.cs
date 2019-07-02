using TaxCalculator.Infrastructure.Interfaces;

namespace TaxCalculator.Implementation
{
    public class Tax : ITax
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
            TaxPercentage taxParcentage = new TaxPercentage(age, gender, taxableIncome);
            var percentage = taxParcentage.GetTaxPercentage();
            return (taxableIncome * percentage) / 100;
        }
    }
}
