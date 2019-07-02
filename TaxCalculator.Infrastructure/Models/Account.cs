namespace TaxCalculator.Infrastructure.Models
{
    public class Account
    {
        public double AnnualSalary { get;  set; }
        public double Bonus { get;  set; }
        public string Gender { get;  set; }
        public int Age { get;  set; }
        public double EightyC_Deduction { get;  set; }
        public Account()
        {

        }
        public Account(double annualSalary, double bonus, string gender,int age, double eightyC_Deduction)
        {
            AnnualSalary = annualSalary;
            Bonus = bonus;
            Gender = gender;
            Age = age;
            EightyC_Deduction = eightyC_Deduction;
            
        }

    }
}
