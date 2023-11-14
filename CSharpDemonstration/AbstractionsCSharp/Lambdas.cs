namespace CSharpDemonstration.AbstractionsCSharp;

public class Lambdas
{
    public static void Main1(string[] args)
    {
        var lambda1 = (int age, string name) =>
        {
            Console.WriteLine($"Your name is {name} and you are {age} years old.");
        };
        lambda1(21, "Tom");
    }
}