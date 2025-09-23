namespace Modul9;

public class Aflevering2App
{
    public static void Run1()
    {
        Aflevering2 a = new();

        foreach (var item in a.Items)
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Stock: {item.Stock}, Color: {item.Color}");
    }
    
    public static void Run2()
    {
        Aflevering2 a = new();

        foreach (var item in a.ItemsInStock())
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Stock: {item.Stock}, Color: {item.Color}");
    }
    
    public static void Run3()
    {
        Aflevering2 a = new();

        foreach (var item in a.ItemsWithColor(["green", "red"]))
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Stock: {item.Stock}, Color: {item.Color}");
    }
}