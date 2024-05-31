internal class Program
{
    private static void Main(string[] args)
    {
        string[] studentNames = new string[] {"Nam", "Hung", "Thang" };
        foreach (var student in studentNames)
        {
            Console.WriteLine($" Student name: {student}");
        }

        //Console.WriteLine("Enter a number");
        //int number = 0;
        //number = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < number; i++)
        //{
        //    if (i%2==0)
        //    {
        //        Console.WriteLine($"So chan {i}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"So Le {i}");
        //    }
        //}
        //switch (number)
        //{
        //    case 1:
        //    case 2:
        //    case 3:
        //        Console.WriteLine("Three");
        //        break;
        //    default:
        //        Console.WriteLine("This is default");
        //        break;
        //}
    }


}