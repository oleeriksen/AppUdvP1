namespace Modul1;

public class Opgave2
{
    public static void Run()
    {
        while (true)
        {
            var input = Console.ReadLine();
            var tal = int.Parse(input);
            if (tal == 0)
                break;
            while (tal >= 1)
            {
                Console.WriteLine(tal);
                tal--;
            }
        }
    }
}