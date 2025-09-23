namespace Modul8;

public class DiceApp
{
    public static void Run()
    {
        
        DiceWithHistory d = new DiceWithHistory(6);

        
        for (int i = 0; i < 20; i++)
        {
            d.Roll();
            int delay = Random.Shared.Next(2000);
            Console.WriteLine($"delay: {delay}");
            Thread.Sleep(delay);
        }

        foreach (var item in d.History)
            Console.WriteLine($"Time: {item.time}, eyes: {item.eyes}");
    }
}