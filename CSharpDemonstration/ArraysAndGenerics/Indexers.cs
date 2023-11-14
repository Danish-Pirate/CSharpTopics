namespace CSharpDemonstration.ArraysAndGenerics;

public class Indexers
{
    public static void Main1(string[] args)
    {
        Box box = new Box();
        Console.WriteLine(box[0]);
        box[2] = "Hammer";

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(box[i]);
        }

        var item = box["Tom"];
    }
}

class Box
{
    private string[] boxArray = { "Keys", "Wrench", "Vacuum", "Lego" };

    public string this[int index]
    {
        get
        {
            return boxArray[index];
        }
        set
        {
            boxArray[index] = value;
        }
    }
    public string this[string name]
    {
        get
        {
            return null;
        }
        set
        {
            
        }
    }
}