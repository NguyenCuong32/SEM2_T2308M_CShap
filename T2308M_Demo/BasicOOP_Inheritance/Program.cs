using BasicOOP_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.Sleep();
        cat.Eat();

        Person person = new Person();
        person.Eat();
        person.Sleep();


        Dog dog = new Dog();
        dog.Sleep();
        dog.Eat();
    }
}