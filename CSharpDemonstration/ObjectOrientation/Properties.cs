namespace CSharpDemonstration.ObjectOrientation;

public class Properties
{
    public static void Main1(string[] args)
    {
        Person person = new Person()
        {
            Age = 21,
            Name = "Tom"
        };
    }
}

class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}