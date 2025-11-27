namespace Modul9;

public class UniqueIds
{
    public void Run()
    {
        Dictionary<long, int> mNumbers = new();
        int i;
        for (i = 1; i < int.MaxValue; i++)
        {
            var id = Random.Shared.NextInt64();
            if (mNumbers.ContainsKey(id))
            {
                Console.WriteLine($"Id clash after {i} new ids");
                break;
            }
            mNumbers.Add(id,1);
        }
        if (i == int.MaxValue)
            Console.WriteLine("NO clash...");

    }
}