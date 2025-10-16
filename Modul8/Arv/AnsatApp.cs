using System.Data.SqlTypes;

namespace Modul8.Arv;

public class AnsatApp
{
    private List<Ansat> ansatte;

    public AnsatApp()
    {
        ansatte = new();
        FuldtidsAnsat egon = new()
        {
            Navn = "Egon",
            Adr = "byvej",
            Email = "egon@mail.dk",
            Fradrag = 1200,
            Trækprocent = 34,
            Frokost = false,
            Gavekasse = true,
            Månedsløn = 34000
        };
        ansatte.Add(egon);
        DeltidsAnsat peter = new()
        {
            Navn = "Peter",
            Adr = "byvej",
            Email = "peter@mail.dk",
            Fradrag = 2300,
            Trækprocent = 42,
            Frokost = true,
            Gavekasse = true,
            AntalTimer = 123,
            Timeløn = 245
        };
        ansatte.Add(peter);

    }

    public void PrintAll()
    {
        foreach (Ansat a in ansatte)
        {
            Console.WriteLine($"Navn: {a.Navn}, Email: {a.Email}, Bruttoløn: {a.BruttoLøn()}");
        }
    }
}