namespace Modul1;

/*Skriv et program som indlæser 2 tal og en regne operator
 ('+', '-', '*' eller '/'), hvorefter det udskriver regne
 operatoren udført på de 2 tal. Til at repræsentere operatoren,
 bruges type char, som er netop et tegn.*/
public class Opgave5
{
    public static void Run()
    {
        var input1 = Console.ReadLine();
        var tal1 = int.Parse(input1);
        var input2 = Console.ReadLine();
        var tal2 = int.Parse(input2);


        var op = Console.ReadLine();
        var resultat = 0;
        if (op == "+")
            resultat = tal1 + tal2;
        else if (op == "*")
            resultat = tal1 * tal2;
        else if (op == "/")
            resultat = tal1 / tal2;
        else Console.WriteLine("Ukendt operator");
        Console.WriteLine($"=> {resultat}");
    }
}