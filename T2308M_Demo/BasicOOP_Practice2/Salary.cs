using System;
namespace BasicOOP_Practice2
{
	public class Salary
	{
		public Salary()
		{
		}
		public Salary(double basicSalary, double bonus)
		{

		}
        public Salary(double basicSalary, double bonus,double orther)
        {

        }

        public decimal SumSalary(decimal basicSalary, decimal bonus)
		{
			return basicSalary + bonus;
		}
        public double SumSalary(double basicSalary, double bonus)
        {
            return basicSalary + bonus;
        }
        public decimal SumSalary(decimal basicSalary, decimal bonus,decimal orther)
		{
			decimal result = basicSalary + bonus +orther;
			return result;
		}
        public double SumSalary(double basicSalary, double bonus, double orther)
        {
            double result = basicSalary + bonus;
            return result;
        }
    }
}

