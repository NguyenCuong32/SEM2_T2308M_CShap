using System;
namespace BasicOOP_Practice1
{
	public class Car
	{
        private string color;
        private string manufacture;
        private string number;

        public string Color { get => color; set => color = value; }

        public string Manufacture { get => manufacture; set => manufacture = value; }

        public string Number { get => number; set => number = value; }
        public Car()
		{
		}
        public Car(string manufacture, string color, string number)
        {
            this.manufacture = manufacture;
            this.color = color;
            this.number = number;
        }
        public void SpeedUp()
        {
            Console.WriteLine($"Manufacture: {manufacture}, Color {color}, Number {number} Speed up");
        }
         public void SpeedDown()
        {
            Console.WriteLine($"Manufacture:{manufacture}, Color {color}, Number {number} Speed down");
        }


	}
}

