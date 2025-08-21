namespace Modul1;

public class Opgave3
{
    public static void Run()
    {
        var input = Console.ReadLine();
        var tal = int.Parse(input);
        for (var t = 2; t <= tal; t++)
            if (int.IsEvenInteger(t))
                Console.WriteLine(t);
    }
}