namespace CSharpDemonstration.AbstractionsCSharp;

public class Delegates
{
    public static void Main1(string[] args)
    {
        new Example().Run();
    }

    public static void PrintHi(string name)
    {
        Console.WriteLine("Hi " + name);
    }

    public static void PrintBye(string name)
    {
        Console.WriteLine("Bye " + name);
    }
}

public class Example
{
    private delegate void SaySomething(string name);

    public void Run()
    {
        //SayHi del1 = new SayHi(Delegates.PrintHi);
        //del1.Invoke("Tom");
        SaySomething del2 = Delegates.PrintHi;
        SaySomething del3 = Delegates.PrintBye;
        SaySomething combined = del2 + del3;
        combined("Tom");
    }
}