namespace BasicOOP_Abstract;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Sound();
        dog.Run();
        //dog.Eat();

        Cat cat = new Cat();
        cat.Sound();
        cat.Run();
        //cat.Eat();
    }
}

