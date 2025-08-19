namespace Modul1;

public class Greeting
{
    public static void Run()
    {
        DateTime now = DateTime.Now;
        int hour = now.Hour;
        Console.Write($"Enter name - time is {hour}: ");
        string name = Console.ReadLine();
        if (hour < 9)
             Console.WriteLine($"Hello {name} - have a nice morning...");
        else
            Console.WriteLine($"Hello {name}  have a nice afternoon...");
    }
}

