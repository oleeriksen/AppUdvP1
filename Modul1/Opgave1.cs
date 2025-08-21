namespace Modul1;

public class Opgave1
{
    public static void Run()
    {
        var input1 = Console.ReadLine();
        var input2 = Console.ReadLine();
        var tal1 = int.Parse(input1);
        var tal2 = int.Parse(input2);
        var sum = tal1 + tal2;
        Console.WriteLine($"Summen er {sum}");
    }
}