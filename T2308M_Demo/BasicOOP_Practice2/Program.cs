using BasicOOP_Practice2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Salary salary = new Salary();
        //decimal basicSalary = 100;
        //decimal bonus = 10;
        //decimal sumSalary = salary.SumSalary(basicSalary, bonus);
        //Console.WriteLine(sumSalary);


        //decimal sumSalaryAll = salary.SumSalary(basicSalary, bonus, 5);
        //Console.WriteLine(sumSalaryAll);

        Rectagle rectagle = new Rectagle();
        rectagle.ChieuDai = 10;
        rectagle.ChieuRong = 20;
        double dientichHinhChuNhat = rectagle.DienTich();
        Console.WriteLine($"Dien tich la {dientichHinhChuNhat}");
    }
}