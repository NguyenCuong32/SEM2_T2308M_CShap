namespace DemoDelegate;

class Program
{
    public delegate void Callback(string message);

    public delegate void AnimalCallback(string food);

    static void Main(string[] args)
    {
        Console.WriteLine("Demo delegate");

        //Callback callback = DelegateMethod;
        //DelegateMethod("Xin chao cac ban");
        //callback.Invoke("Xin chao cac ban");
        //callback("Xin chao cac ban");


        Animal animal = new Animal();
        animal.Eat("meat");
        AnimalCallback animalCallback = animal.Eat;
        animalCallback.Invoke("Meat");
  
    }
    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }
}

