namespace Modul1;

public class Opgave2
{
    public static void Run()
    {
        string input = Console.ReadLine();
        int tal = int.Parse(input);
        while (tal >= 1)
        {
            Console.WriteLine(tal);
            tal--;
        }
    }
}