namespace Modul4;

public class Opgave2
{
    public static void Run()
    {
        int[] a = ReadGrades();
        Console.WriteLine($"Gennemsnit: {Average(a)}");

        int[] grades = { -3, -0, 2, 4, 7, 10, 12 };
        
        foreach (int keyGrade in grades) {
            int count = CountGrades(a, keyGrade);
            Console.WriteLine($"antal {keyGrade}: {count}");
        }
    }

    /// <summary>
    /// Reads a number of grades from the Console. 
    /// </summary>
    static int[] ReadGrades()
    {
        int[] result;
        Console.Write("Indtast hvor mange karaktere: ");
        int n = int.Parse(Console.ReadLine());
        result = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Indtast karakter nr {i + 1}:");
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    /// <summary>
    /// Returnerer gennemsnittet af tallene i a
    /// </summary>
    static double Average(int[] a)
    {
        double res = 0;
        foreach (int v in a)
            res += v;
        return res / a.Length;
    }

    /// <summary>
    /// Return how many values in a that are equal to keyGrade
    /// </summary>
    static int CountGrades(int[] a, int keyGrade)
    {
        int res = 0;
        foreach (int g in a)
            if (g == keyGrade)
                res++;
        return res;
    }

}