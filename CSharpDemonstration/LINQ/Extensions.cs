namespace CSharpDemonstration.LINQ;

public class Extensions
{
    public static void Main1(string[] args)
    {
        List<Object> list = new List<Object>() { "Tom", "Goose", "Joe", "Joshua" };
        list.Shuffle();
        list.ForEach(Console.WriteLine);
    }
}

public static class ListExtension
{
    public static void Shuffle(this List<Object> list)
    {
        Random random = new Random();
        var newList = list.OrderBy((e)=>random.Next()).ToList();

        for (int i = 0; i < newList.Count; i++)
        {
            list[i] = newList[i];
        }
    }
}