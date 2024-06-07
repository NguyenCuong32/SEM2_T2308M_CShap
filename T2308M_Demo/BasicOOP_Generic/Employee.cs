using System;
namespace BasicOOP_Generic
{
	public class Employee
	{
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void DoSomething()
        {
            Console.WriteLine("Do something....");
        }
    }
}

