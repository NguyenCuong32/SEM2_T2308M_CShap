using System;
namespace OOP_Practice_4
{
    public class ProductionEmployee : Employee
    {
        const decimal factorSalary = 3.5m;
        public override decimal GetSalary(decimal basicSalary)
        {
            return factorSalary * basicSalary;
        }
    }
}

