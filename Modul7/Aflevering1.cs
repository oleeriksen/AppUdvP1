using System;
using System.Collections.Generic;

namespace Modul7;


public class Aflevering1
{
    public void Run()
    {
        var words = readwords();
        Console.WriteLine($"Antal ord: {words.Count}");
// Punkt 2
        FindShortestAndLongest(words);
// Punkt 3
        Console.WriteLine($"ord med længde mindst 4:");

        var longWords = GetWordsWithMinLength(words, 4);
        foreach (var word in longWords)
            Console.WriteLine(word);
// Punkt 4
        PrintWordsWithoutVowels(words);
    }

//punkt 1
    private List<string> readwords() //indlæser ord fra tastaturet
    {
        var result = new List<string>(); //tom liste til at gemme ord
        while (true) //kører indtil vi stopper den
        {
            Console.WriteLine("Indtast et Ord eller skriv /stop:");
            var input = Console.ReadLine(); //læser brugerens indput
            if (input == "/stop") //hvis brugeren siger /stop så stopper løkken
                break;
            result.Add(input); // ellers tilføjer vi ordet til listen
        }

        return result; //listen returneres med alle ord
    }

//find korteste og længste ord - Punkt 2
    private void FindShortestAndLongest(List<string> words)
    {
        if (words.Count == 0) //tjek om listen er tom
        {
            Console.WriteLine("Ingen ord indtastet");
            return;
        }

        string shortest = words[0]; //starter med første ord
        string longest = words[0];
        foreach (var word in words) //går igennem alle ord
        {
            if (word.Length < shortest.Length)
            {
                shortest = word;
            }

            if (word.Length > longest.Length)
            {
                longest = word; //her finder vi længste ord
            }
        }

        Console.WriteLine($"Shortest ord: {shortest}");
        Console.WriteLine($"Longest ord: {longest}");
    }

//Udskriv ord med min længde - Punkt 3
    private List<string> GetWordsWithMinLength(List<string> words, int minLength)
    {
        List<string> result = new();
        foreach (var word in words) //gennemløber ord i listen
        {
            if (word.Length >= minLength)
                result.Add(word);
        }
        return result;
    }

//udskriv ord uden Danske vokaler - Punkt 4
    private void PrintWordsWithoutVowels(List<string> words)
    {
        Console.WriteLine("Ord uden danske vokaler");
        foreach (var word in words)
        {
            if (!ContainsDanishVowel(word)) //tjekker om ordet IKKE indeholder en vokal
            Console.WriteLine(word); //udksriver hvis det ikke indeholder vokal
        }
    }

// Hjælpefunktion: tjekker om ordet har en vokal (a, e, i, o, u, y, æ, ø, å)
    private bool ContainsDanishVowel(string word)
    {
        string vowels = "aeiouyæøå";
        word = word.ToLower();
        foreach (char c in word) //gennemgå hvert tegn i ordet
        {
            if (vowels.Contains(c)) //hvis tegnet findes i vores streng med vokaler
                return true; //så har ordet en vokal
        }

        return false; //ellers ikke, her.
    }
}