namespace OOP_Practice_4;

class Program
{
    static void Main(string[] args)
    {
        AdminEmployee admin = new AdminEmployee();
        admin.Bonus = 200;
        Console.WriteLine(admin.GetSalary(500));

        ProductionEmployee production = new ProductionEmployee();
        Console.WriteLine(production.GetSalary(300)); ;
    }
}

