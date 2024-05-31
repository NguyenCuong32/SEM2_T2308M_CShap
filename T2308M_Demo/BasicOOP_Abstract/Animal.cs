using System;
namespace BasicOOP_Abstract
{
	public abstract class Animal
	{
		public abstract void Sound();

		public void Eat()
		{
			Console.WriteLine("Animal eat.");
		}
	}
}

