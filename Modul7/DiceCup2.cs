namespace Modul7;

public class DiceCup2
{
    private Dice[] dices;

    public DiceCup2(int n = 5)
    {
        dices = new Dice[n];
        for (int i=0; i < n; i++)
           dices[i] = new Dice(6);
    }

    public void Shake()
    {
        foreach (var dice in dices)
            dice.Roll();
    }

    public int[] Eyes()
    {
        int[] res = new int[dices.Length];
        for (int i=0; i < res.Length; i++)
           res[i] = dices[i].GetEyes();
        Array.Sort(res);
        return res;
    }
}