using BasicOOP_Practice1;
using System.Data;
internal class Program
{
    private static void Main(string[] args)
    {
        Car bmw = new Car();
        bmw.Manufacture = "BMW";
        bmw.Color = "Black";
        bmw.Number = "29A-9999";
        bmw.SpeedUp();


        Car vinfastEF3 = new Car();
        vinfastEF3.Manufacture = "Vin fast";
        vinfastEF3.Color = "Red";
        vinfastEF3.Number = "80A-8888";
        vinfastEF3.SpeedDown();


        Car audi = new Car() { Manufacture = "Audi", Color = "Blue", Number = "29A-6868" };
        audi.SpeedUp();

        Car ford = new Car("Ford", "Black", "80A-9999");
        ford.SpeedUp();



    }
}