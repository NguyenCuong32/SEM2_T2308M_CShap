using Basic_oop;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Person mai = new Person();
        //mai.Age = 12;
        //mai.Name = "Mai";
        //mai.Sex = "Woman";
        //mai.Weight = 25;
        //mai.Height = 140;
        //mai.Walk();

        Person mai = new Person() { Age = 12, Height = 140, Name = "Mai" };
        mai.Walk();
        Teacher cuong = new Teacher();
        cuong.Walk();
        cuong.GetName();
    }
}