namespace Modul9;

public class SetandList
{
    public void Try1()
    {
        List<int> a = [1, 2, 3, 4];
        List<int> b = [3, 4, 5, 6];
        
        var tmp = a.ToHashSet();
        tmp.UnionWith(b.ToHashSet());
        a = tmp.ToList();

        foreach (int v in a)
            Console.WriteLine(v);
    }
}