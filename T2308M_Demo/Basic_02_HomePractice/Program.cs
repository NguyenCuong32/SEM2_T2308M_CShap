internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //int salary = 0;
        //int bonus = 0;
        //salary = Convert.ToInt32(Console.ReadLine());
        //bonus = Convert.ToInt32(Console.ReadLine());

        //int summarySalary = Summary(salary, bonus);

        //Console.WriteLine($"Summary: {summarySalary}");

        //int[] array1 = new int[3] { 2, 4, 5 };

        //int[] array2 = new int[5] { 2, 90, 5,6,8 };


        //var results = array2.(array1).ToList();

        //foreach (var item in results)
        //{
        //    Console.WriteLine(item);
        //}
       
        string start = string.Empty;
        string startShow = string.Empty;
        for (int i = 0; i < 4; i++)
        {
            start += "*";
            startShow = start + "\r\n";
            Console.WriteLine(startShow);
        }

        Console.ReadKey();
    }
    private static int Summary(int salary, int bonus)
    {
        return salary + bonus;
    }
}