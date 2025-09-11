namespace Modul7;

public class Opgave71
{
    public void Run()
    {
        DiceCup1 dc = new DiceCup1(40);

        for (int i = 0; i < 10; i++)
        {
            dc.Shake();
            var eyes = dc.Eyes();
            Console.WriteLine(String.Join(',', eyes));
        }
    }
}