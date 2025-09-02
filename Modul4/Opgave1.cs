namespace Modul4;

public class Opgave1
{
    public static void Run()
    {
        int[] a = ReadNumbers();
        Console.WriteLine($"Gennemsnit: {Average(a)}");
        Console.WriteLine($"Varians: {Varians(a)}");
        Console.WriteLine($"St afvigelse: {Deviation(a)}");

    }

    static int[] ReadNumbers()
    {
        int[] result;
        Console.Write("Indtast hvor mange tal: ");
        int n = int.Parse(Console.ReadLine());
        result = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Indtast tal nr {i + 1}:");
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    //Returnerer gennemsnittet af tallene i a
    static double Average(int[] a)
    {
        double res = 0;
        int idx = 0;
        while (idx < a.Length) {
            res += a[idx];
            idx++;
        }

        return res / a.Length;
    }

    /// <summary>
    /// Compute the varians of a 
    /// </summary>
    static double Varians(int[] a)
    {
        double res = 0;
        double avg = Average(a);
        foreach (int v in a)
            res += Math.Pow(v - avg, 2);
        return res / a.Length;
    }

    //Returnerer standardafvigelsen af tallene i a
    static double Deviation(int[] a) {
        return Math.Sqrt(Varians(a));
    }
}