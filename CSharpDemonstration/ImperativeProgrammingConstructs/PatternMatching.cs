namespace CSharpDemonstration.ImperativeProgrammingConstructs;

public class PatternMatching
{
    public static void Main1(string[] args)
    {
        String s = "hello";
        int num = 7;
        float num2 = 12.1F;
        char character = 'A';
        
        checkType(s);
        checkType(num);
        checkType(num2);
        checkType(character);

        Person p1 = new Person(21, "Dante");
        Person p2 = new Person(21, "Pante");
        Person p3 = new Person(16, "Virgil");
        checkPerson(p1);
        checkPerson(p2);
        checkPerson(p3);
    }

    public static void checkType(object obj) // Type matching
    {
        if (obj is string str)
            Console.WriteLine($"Object is a string of length {str.Length}");
        else if (obj is int or float)
            Console.WriteLine($"Object is a number with the value {obj}");
        else if (obj is char character)
            Console.WriteLine($"Object is a character with the value {character}");
        else
            Console.WriteLine("Don't know the type of the object");
    }

    static void checkPerson(Person person) // Property matching
    {
        switch (person)
        {
            case {Age: > 18, Name:"Dante"}:
                Console.WriteLine("Dante is over 18 years old.");
                break;
            case {Age: < 18, Name:"Virgil"}:
                Console.WriteLine("Virgil is under 18 years old.");
                break;
            default:
                Console.WriteLine("Unknown person");
                break;
        }
    }
    public record Person(int Age, string Name);
}