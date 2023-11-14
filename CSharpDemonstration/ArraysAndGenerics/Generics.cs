using System.Collections;

namespace CSharpDemonstration.ArraysAndGenerics;

public class Generics
{
    public static void Main1(string[] args)
    {
        ReverseList<string> reverseList = new ReverseList<string>("Dogs", "Geese", "Cats");
        
        for (int i = 0; i < reverseList.Length; i++)
        {
            Console.WriteLine(reverseList.Get(i));
        }
    }
}

class ReverseList<T>
{
    private readonly T[] _list;

    public T Get(int index)
    {
        return _list[index];
    }

    public int Length => _list.Length;

    public ReverseList(params T[] array)
    {
        _list = new T[array.Length];
        Array.Copy(array, _list, array.Length);
        Array.Reverse(_list);
    }
}