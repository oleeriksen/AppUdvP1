namespace Modul5;

public class Opgave1
{
    public static void Run()
    {
        List<int> a = ReadNumbers();
        Console.WriteLine($"Gennemsnit: {Average(a)}");
        Console.WriteLine($"Varians: {Varians(a)}");
        Console.WriteLine($"St afvigelse: {Deviation(a)}");

    }

    static List<int> ReadNumbers()
    {
        List<int> result = new();

        int i = 1;
        while (true)
        {
            Console.Write($"Indtast tal nr {i}:");
            string input = Console.ReadLine();
            if (input.Equals("stop", StringComparison.InvariantCultureIgnoreCase))
                break;
            int tal = int.Parse(input);
            result.Add(tal);
            i++;
        }

        return result;
    }

    //Returnerer gennemsnittet af tallene i a
    static double Average(List<int> a)
    {
        double res = 0;
        int idx = 0;
        while (idx < a.Count) {
            res += a[idx];
            idx++;
        }
        return res / a.Count;
    }

    /// <summary>
    /// Compute the varians of a 
    /// </summary>
    static double Varians(List<int> a)
    {
        double res = 0;
        double avg = Average(a);
        foreach (int v in a)
            res += Math.Pow(v - avg, 2);
        return res / a.Count;
    }

    //Returnerer standardafvigelsen af tallene i a
    static double Deviation(List<int> a) {
        return Math.Sqrt(Varians(a));
    }
}