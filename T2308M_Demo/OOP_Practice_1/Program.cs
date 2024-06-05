namespace OOP_Practice_1;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.Height = 4;
        square.Width = 4;
        Console.WriteLine($"Area: {square.Area()} m^2");

        Console.WriteLine($"Perimeter: {square.Perimeter()} m");

        Circle circle = new Circle();
        circle.radius = 30;
        Console.WriteLine($"Area: {circle.Area()}");
        Console.WriteLine($"Perimeter: {circle.Perimeter()}");

        Console.ReadKey();
    }
}

