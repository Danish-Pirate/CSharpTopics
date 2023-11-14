namespace CSharpDemonstration.ArraysAndGenerics;

public class Arrays
{
    public static void Main1(string[] args)
    {
        int[] numbers = { 5, 1, 4, 3 };
        int[] numbers2 = new int[10];

        // Jagged arrays. Dimensions of inner arrays can differ
        int[][] jagged = { new int[] { 4, 1, 2, 7, 1 }, new int[] { 1, 5, 1 } };
        Console.WriteLine(jagged[0][1]);

        // Multi-dimensional arrays. Inner arrays cannot differ in size
        int[,] multiDimensional =
        {
            { 5, 1, 4 },
            { 4, 2, 5 },
            { 1, 2, 5 }
        };
        Console.WriteLine(multiDimensional[0, 2]);
        
        Array.ForEach(jagged, innerArray => Array.ForEach(innerArray, Console.Write));
    }
}