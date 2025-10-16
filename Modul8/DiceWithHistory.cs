namespace Modul8;

public class DiceWithHistory : Dice
{
    private List<(DateTime time, int eyes)> mHistory = new();
    public DiceWithHistory(int size) : base(size)
    {
    }

    public override void Roll()
    {
        base.Roll();
        mHistory.Add( (DateTime.Now, GetEyes()) );
    }

    public List<(DateTime time, int eyes)> History => mHistory;
}