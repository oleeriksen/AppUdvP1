namespace Modul5;

public class Opgave2
{
    public static void Run()
    {
        List<int> a = ReadGrades();
        Console.WriteLine($"Gennemsnit: {Average(a)}");

        List<int> grades = new() { -3, -0, 2, 4, 7, 10, 12 };
        
        foreach (int keyGrade in grades) {
            int count = CountGrades(a, keyGrade);
            Console.WriteLine($"antal {keyGrade}: {count}");
        }
    }

    /// <summary>
    /// Reads a number of grades from the Console. 
    /// </summary>
    static List<int> ReadGrades()
    {
        List<int> result = new();

        int i = 1;
        while (true)
        {
            Console.Write($"Indtast karakter nr {i}:");
            string input = Console.ReadLine();
            if (input.Equals("stop", StringComparison.InvariantCultureIgnoreCase))
                break;
            int tal = int.Parse(input);
            result.Add(tal);
            i++;
        }

        return result;
    }

    /// <summary>
    /// Returnerer gennemsnittet af tallene i a
    /// </summary>
    static double Average(List<int> a)
    {
        double res = 0;
        foreach (int v in a)
            res += v;
        return res / a.Count;
    }

    /// <summary>
    /// Return how many values in a that are equal to keyGrade
    /// </summary>
    static int CountGrades(List<int> a, int keyGrade)
    {
        int res = 0;
        foreach (int g in a)
            if (g == keyGrade)
                res++;
        return res;
    }

}