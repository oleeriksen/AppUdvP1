namespace Modul8.Arv;

public class Ansat
{
    public string Navn { get; set; } = String.Empty;
    public string Adr { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public float Fradrag { get; set; }
    public float Trækprocent { get; set; }
    public bool Frokost { get; set; } = true;
    public bool Gavekasse { get; set; }

    public virtual double BruttoLøn() => -1;
}