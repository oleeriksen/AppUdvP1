namespace Modul1;

public class Opgave3
{
    public static void Run()
    {
        string input = Console.ReadLine();
        int tal = int.Parse(input);
        for (int t = 2; t <= tal; t++)
        {
            if (int.IsEvenInteger(t))
                Console.WriteLine(t);
        }
    }
}