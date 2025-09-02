namespace Modul6;

public class Dice
{
    private int eyes;

    private int size;

    private Random r;

    public Dice(int size = 6)
    {
        this.size = size;
        r = new();
    }

    public void Roll() {
        eyes = r.Next(size)+1;
    }

    public int GetEyes() {
        return eyes;
    }
}