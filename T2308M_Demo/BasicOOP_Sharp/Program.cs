namespace BasicOOP_Sharp;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Sharp calculate");
            double width = 0;
            double height = 0;
            width = Convert.ToDouble(Console.ReadLine());
            height = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            double areas = rectangle.Areas(width, height);
            Console.WriteLine($"Dien tich hinh chu nhat: {areas}");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finaly exception");
        }
    }
}

