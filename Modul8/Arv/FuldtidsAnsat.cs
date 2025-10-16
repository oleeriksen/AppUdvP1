namespace Modul8.Arv;

public class FuldtidsAnsat : Ansat
{
    public int Månedsløn { get; set; }

    public override double BruttoLøn()
    {
        return Månedsløn;
    }
}