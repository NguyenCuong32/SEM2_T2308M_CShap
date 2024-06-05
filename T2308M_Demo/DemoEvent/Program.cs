namespace DemoEvent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Event Example");
        BusinessProcess businessProcess = new BusinessProcess();
        businessProcess.OnProcess += BusinessProcess_OnProcess;
        businessProcess.StartProcess();
    }

    private static void BusinessProcess_OnProcess()
    {
        Console.WriteLine("Completed Event");
    }
}

