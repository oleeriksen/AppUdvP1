namespace ReadExcel;

public class App
{
    public void Run()
    {
        string filename = "data.csv";
        string[] allLines = File.ReadAllLines(filename);
        int lnr = 1;
        foreach (var line in allLines)
        {
            Console.WriteLine($"{lnr}: {line}");
            lnr++;
        }

        for (int i = 1; i < allLines.Length; i++)
        {
            string[] parts = allLines[i].Split(";");
            string dato = parts[0];
            int timer = int.Parse(parts[2]);
            Console.WriteLine($"{dato}, {timer}");
        }

    }
}