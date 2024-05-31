using System;
namespace BasicOOP_Abstract
{
	public class Cat:Animal, IAnimal
	{
		public Cat()
		{
		}

        public void Run()
        {
            Console.WriteLine("Cat is running");
        }

       

        public override void Sound()
        {
            Console.WriteLine("Meo meo");
        }
    }
}

