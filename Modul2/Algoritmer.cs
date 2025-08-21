namespace Modul2;

public class Algoritmer
{
    public static void Run()
    {
        //int m = FindMax(3, 21, 6);
        //Console.WriteLine(m);
        double netto = NettoLøn(23000, 39, 3500, true, false);
        Console.WriteLine(netto);
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