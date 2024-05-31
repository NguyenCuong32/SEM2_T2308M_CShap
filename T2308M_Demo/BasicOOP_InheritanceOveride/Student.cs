using System;
namespace BasicOOP_InheritanceOveride
{
	public sealed class Student
	{
        private string name;
        private string address;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
       public void PrintDetail()
        {
            Console.WriteLine($"Student name {name}, address {address}");
        }
	}
}

