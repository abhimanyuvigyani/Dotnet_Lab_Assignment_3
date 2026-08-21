using System;

namespace Dotnet_Assignment_3
{
    sealed class EmployeePayroll
    {
        public double CalculateSalary(double basicSalary, double allowance)
        {
            return basicSalary + allowance;
        }

        public double CalculateTax(double salary)
        {
            if (salary >= 100000)
                return salary * 0.20;
            else if (salary >= 50000)
                return salary * 0.10;
            else
                return salary * 0.05;
        }

        public double CalculateNetSalary(double salary, double tax)
        {
            return salary - tax;
        }
    }

    class Que_4
    {
        static void Main4()
        {
            EmployeePayroll employee = new EmployeePayroll();

            double salary = employee.CalculateSalary(60000, 10000);
            double tax = employee.CalculateTax(salary);
            double netSalary = employee.CalculateNetSalary(salary, tax);

            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }
}
