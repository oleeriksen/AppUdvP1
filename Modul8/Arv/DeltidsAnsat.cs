namespace Modul8.Arv;

public class DeltidsAnsat : Ansat
{
    public int AntalTimer { get; set; }
    public float Timeløn { get; set; }

    public override double BruttoLøn()
    {
        return AntalTimer * Timeløn;
    }
}