using System;
namespace OOP_Practice_4
{
    public class AdminEmployee : Employee
    {
        decimal factorSalary = 2.35m;
        private decimal bonus;

        public decimal Bonus { get => bonus; set => bonus = value; }
        public override decimal GetSalary(decimal basicSalary)
        {
            return factorSalary * basicSalary + bonus;
        }
    }
}

