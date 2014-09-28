using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        public string empName;
        public double basicAcc;
        public double houseRent;
        public double medicalAllowance;

        public double getSalary()
        {
            double result = basicAcc + basicAcc*(houseRent/100) + (basicAcc*medicalAllowance/100);
            return result;
        }
    }
}
