namespace Modul2;

public class Algoritmer
{
    public static void Run()
    {
        int[] data = new int[]{ 12, 34, 56, 2, 34};
        int max = FindMax(data);
        Console.WriteLine(max);
        //double netto = NettoLøn(23000, 39, 3500, true, false);
        //Console.WriteLine(netto);
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

    static int FindMax(int[] a)
    {
        int max = int.MinValue;
        foreach (int candidate in a)
        {
            if (candidate > max)
                max = candidate;
        }

        return max;
    }

    static int NoOfRoots(double a, double b, double c)
    {
        double d = b * b - 4 * a * c;
        int antal = 0; // valid if d < 0
        if (d == 0)
            antal = 1;
        else if (d > 0)
            antal = 2;
        return antal;
    }

    static double NettoLøn(int brutto, double traekProcent, int fradrag, 
                           bool gavekasse, bool frokostordning)
    {
        double netto = fradrag;
        brutto -= fradrag;
        double skat = (traekProcent / 100) * brutto;
        netto += (brutto - skat);
        if (gavekasse)
            netto -= 30;
        if (frokostordning)
            netto -= 350;
        return netto;
    }
}