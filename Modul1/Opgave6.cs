namespace Modul1;

public class Opgave6
{
    public static void Run()
    {
        RunC();
    }

    static void RunA()
    {
        for (int i = 0; i < 10; i++) {
            string output = "";
            for (int j = 0; j < 10-i; j++) {
                output = output + "*";
            }
            Console.WriteLine(output);
        }
    }
    
    static void RunB()
    {
        for (int i = 0; i < 10; i++) {
            string output = "";
            for (int j = 0; j < i+1; j++) {
                output = output + "*";
            }
            Console.WriteLine(output);
        }
    }
    
    static void RunC()
    {
        for (int i = 0; i < 10; i++) {
            string output = "";
            // 9-i blanke
            for (int j = 0; j < 9-i; j++) {
                output += " ";
            }
            // i+1 stjerner
            for (int j = 0; j < i+1; j++) {
                output += "*";
            }
            Console.WriteLine(output);
        }
    }
}