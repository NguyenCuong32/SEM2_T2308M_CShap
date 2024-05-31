using System;
namespace BasicOOP_InheritanceOveride
{
	public class Grade:Student
	{
        private double gradePoint;
        private string className;

        public string ClassName { get => className; set => className = value; }
        public double GradePoint { get => gradePoint; set => gradePoint = value; }
        public override void PrintDetail()
        {
            base.PrintDetail();
            Console.WriteLine($"Grade class {className}, Point {gradePoint}");
        }

    }
}

