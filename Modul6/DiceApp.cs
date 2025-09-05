namespace Modul6;

public class DiceApp
{
    public static void Run()
    {
        Dice d = new Dice(10);

        for (int i = 0; i < 100; i++)
        {
            d.Roll();
            Console.WriteLine($"{d.GetEyes()}");
        }

    }
}