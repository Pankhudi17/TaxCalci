namespace TaxCalculator.Infrastructure.Interfaces
{
    public interface ITax
    {
       double GetTaxableIncome(double bonus, double annualSalary, double eightyC_Deduction);
       double GetTotalTax(int age, string gender, double taxableIncome);
    }
}
