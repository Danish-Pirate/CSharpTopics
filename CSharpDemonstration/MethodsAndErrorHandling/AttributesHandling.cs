namespace CSharpDemonstration.MethodsAndErrorHandling;
using System.Reflection;

public class AttributesHandling
{
    public static void Main1(string[] args)
    {
        var methodInfos = typeof(AttributesHandling).GetMethods();
        
        foreach(var method in methodInfos)
            if (method.GetCustomAttributes().FirstOrDefault() is PrinterAttribute)
                Console.WriteLine($"The method {method.Name} prints to the console!");
    }
    
    [Printer("This method prints to the console")]
    public static void SayHi()
    {
        Console.WriteLine("Hi");
    }
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class PrinterAttribute : Attribute
{
    public PrinterAttribute(string description)
    {
        Console.WriteLine("The printer attribute has been used with the description: " + description);
    }
}