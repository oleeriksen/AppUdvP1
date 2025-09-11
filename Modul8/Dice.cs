namespace Modul8;

public class Dice
{
    // state
    private int size;
    private int eyes;
    private Random mGenerator;

    public Dice(int size)
    {
        this.size = size;
        mGenerator = new Random();
        eyes = mGenerator.Next(1, size+1);
    }

    public int GetEyes() => eyes;

    public virtual void Roll()
    {
        eyes = mGenerator.Next(1, size+1);
    }


}