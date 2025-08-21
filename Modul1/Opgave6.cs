namespace Modul1;

public class Opgave6
{
    public static void Run()
    {
        RunC();
    }

    private static void RunA()
    {
        for (var i = 0; i < 10; i++)
        {
            var output = "";
            for (var j = 0; j < 10 - i; j++) output = output + "*";
            Console.WriteLine(output);
        }
    }

    private static void RunB()
    {
        for (var i = 0; i < 10; i++)
        {
            var output = "";
            for (var j = 0; j < i + 1; j++) output = output + "*";
            Console.WriteLine(output);
        }
    }

    private static void RunC()
    {
        for (var i = 0; i < 10; i++)
        {
            var output = "";
            // 9-i blanke
            for (var j = 0; j < 9 - i; j++) output += " ";
            // i+1 stjerner
            for (var j = 0; j < i + 1; j++) output += "*";
            Console.WriteLine(output);
        }
    }
}