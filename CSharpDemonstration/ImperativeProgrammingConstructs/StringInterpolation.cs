namespace CSharpDemonstration.ImperativeProgrammingConstructs;

class StringInterpolation
{
    static void Main1(string[] args)
    {
        string firstName = "Tom";
        string lastName = "Goose";
        
        Console.WriteLine($"Hello {firstName} {lastName}");

        string path = @"\home\tomgoose\Documents";
        Console.WriteLine(path);

        string firstName2 = "Jonathan";
        string lastName2 = "Johnson";
        
        Console.WriteLine($"{firstName, -8} {lastName}\n{firstName2, -8} {lastName2}");

        float num = 3.414141f;
        Console.WriteLine($"{num:F3}");
        Console.WriteLine($"{num:C}");
    }
}