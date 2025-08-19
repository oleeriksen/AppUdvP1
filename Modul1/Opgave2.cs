namespace Modul1;

public class Opgave2
{
    public static void Run()
    {
        while (true)
        {
            string input = Console.ReadLine();
            int tal = int.Parse(input);
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