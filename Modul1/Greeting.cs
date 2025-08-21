namespace Modul1;

public class Greeting
{
    public static void Run()
    {
        var now = DateTime.Now;
        var hour = now.Hour;
        Console.Write($"Enter name - time is {hour}: ");
        var name = Console.ReadLine();
        if (hour < 9)
            Console.WriteLine($"Hello {name} - have a nice morning...");
        else
            Console.WriteLine($"Hello {name}  have a nice afternoon...");
    }
}