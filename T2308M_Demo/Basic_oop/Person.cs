using System;
namespace Basic_oop
{
	public class Person
	{
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get { return age + 3;  } set => age = value; }
        public string Sex { get; set; }
		public int Height { get; set; }
		public double Weight { get; set; }


		public Person(int age, string sex, int height)
		{
            Age = age;
        }
        public Person()
        {
            this.GetName();
        }
        internal void GetName()
		{
			try
			{

			}
			catch (Exception ex)
			{
				throw new NotImplementedException();
			}
			Console.WriteLine("Got the name");
		}
		public void Walk()
		{
			Console.WriteLine("I am walking.");
		}
		public void Eat()
		{
			Console.WriteLine("I am have breakfast.");
		}
	}
}

