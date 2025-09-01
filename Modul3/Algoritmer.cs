namespace Modul3;

public class Algoritmer
{
    public static void Run()
    {
        //int m = FindMax(100, 30, 34);
        //Console.WriteLine(m);
        //int[] data = new[] { 1, 2, 3, 4, 5, 5 };
        //int resultat = SumAfLigeTal(data);
        //Console.WriteLine(resultat);
        int res = AntalRødder(1, 0, 1);
        Console.WriteLine(res);

        var res1 = Frankering(23);
        
    }

    static int FindMax(int a, int b, int c)
    {
        int max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
        return max;
    }

    static int SumAfLigeTal(int[] a)
    {
        int sum = 0;
        int i = 0;
        while (i < a.Length)
        {
            if (a[i] % 2 == 0) // if a[i] is even
                sum = sum + a[i];
            i = i + 1;
        }
        return sum;
    }
    
    static int SumAfLigeTal2(int[] a)
    {
        int sum = 0;
        
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0) // if a[i] is even
                sum = sum + a[i];
        }
        return sum;
    }
    
    static int SumAfLigeTal3(int[] a)
    {
        int sum = 0;
        
        foreach (int element in a)
        {
            if (element % 2 == 0) // if a[i] is even
                sum = sum + element;
        }
        return sum;
    }
    
    

    static int AntalRødder(int a, int b, int c)
    {
        int d = b * b - 4 * a * c;
        int antal = 0;
        if (d < 0)
            antal = 0;
        if (d == 0)
            antal = 1;
        if (d > 0)
            antal = 2;
        return antal;
    }

    static (int antal3, int antal5) Frankering(int amount)
    {
        // kod her...
        return (4, 5);
    }
}