namespace CSharpDemonstration.ArraysAndGenerics;

public class IndiciesRangesSpans
{
    public static void Main1(string[] args)
    {
        // Indices
        string[] animals = { "Goose", "Dog", "Cat", "Elephant", "Giraffe", "Lion", "Zebra", "Horse" };
        Index firstIndex = 0;
        Index lastIndex = ^1;
        Console.WriteLine(animals[firstIndex]);
        Console.WriteLine(animals[lastIndex]);
        
        // Ranges
        // Consists of two indices. Start index is inclusive while end index is exclusive.
        Range animalRange = 2..6;
        foreach (var animal in animals[animalRange])
        {
            Console.Write(animal + " ");
        }
        Console.WriteLine();

        foreach (var animal in animals[^4..])
        {
            Console.Write(animal + " ");
        }
        Console.WriteLine();
        
        foreach (var animal in animals[..^3])
        {
            Console.Write(animal + " ");
        }
        Console.WriteLine();
        
        // Span
        Span<string> animalSpan = animals[2..4];
        foreach (var animal in animalSpan)
        {
            Console.WriteLine(animal);
        }
    }
}