using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Implementation
{
    public class TaxPercentage
    {
        public int  age;
        public string gender;
        public double salary = 0;

        public TaxPercentage(int age, string gender, double salary)
        {
            this.age = age;
            this.gender = gender;
            this.salary = salary;
        }

        public int GetTaxPercentage()
        {
            if (age > 18 && age < 59)
            {
                if (gender == "M" || gender == "Male")
                {
                    if (salary > 0 && salary < 180000)
                    {
                        return 0;
                    }
                    if (salary > 180000 && salary < 500000)
                    {
                        return 10;
                    }
                    if (salary > 500000 && salary < 800000)
                    {
                        return 20;
                    }
                    if (salary > 800000)
                    {
                        return 30;
                    }
                }
                if (gender == "F" || gender == "Female")
                {
                    if (salary > 0 && salary < 190000)
                    {
                        return 0;
                    }
                    if (salary > 190000 && salary < 500000)
                    {
                        return 10;
                    }
                    if (salary > 500000 && salary < 800000)
                    {
                        return 20;
                    }
                    if (salary > 800000)
                    {
                        return 30;
                    }
                }
            }
            if (age > 60 && age < 79)
            {
                if (salary > 0 && salary < 250000)
                {
                    return 0;
                }
                if (salary > 250001 && salary < 500000)
                {
                    return 10;
                }
                if (salary > 500001 && salary < 800000)
                {
                    return 20;
                }
                if (salary > 800000)
                {
                    return 30;
                }
            }
            if (age > 80)
            {
                if (salary > 0 && salary < 500000)
                {
                    return 0;
                }
                if (salary > 500001 && salary < 800000)
                {
                    return 10;
                }
                if (salary > 800000)
                {
                    return 20;
                }
            }
            return -1;
        }
    }
}
