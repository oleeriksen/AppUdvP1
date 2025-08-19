namespace Modul1;

public class Opgave1
{
    public static void Run()
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        int tal1 = int.Parse(input1);
        int tal2 = int.Parse(input2);
        int sum = tal1 + tal2;
        Console.WriteLine($"Summen er {sum}");
    }
}