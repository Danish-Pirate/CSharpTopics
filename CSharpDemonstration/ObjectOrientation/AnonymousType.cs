namespace CSharpDemonstration.ObjectOrientation;

public class AnonymousType
{
    public static void Main1(string[] args)
    {
        var anon = new { Name = "Tom", Age = "21" };
        Console.WriteLine(anon.Name + " " + anon.Age);
    }
}