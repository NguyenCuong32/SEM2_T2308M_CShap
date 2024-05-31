using System;
namespace BasicOOP_Abstract
{
	public class Dog: IAnimal
	{
		public Dog()
		{
		}

        public void Run()
        {
            Console.WriteLine("Dog is running");
        }

        public void Sound()
        {
            Console.WriteLine("Gau gau");
        }
    }
}

