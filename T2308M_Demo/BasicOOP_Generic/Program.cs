namespace BasicOOP_Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Example Generic");
        GenerticList<Employee> generticList = new GenerticList<Employee>();

        generticList.Add(new Employee() { Name = "Nam", Age = 35 });
        generticList.Add(new Employee() { Name = "Hoang", Age = 25 });

        foreach (var item in generticList.listObject)
        {
            Console.WriteLine($"Name {item.Name} Age {item.Age}");
        }
    }
}

