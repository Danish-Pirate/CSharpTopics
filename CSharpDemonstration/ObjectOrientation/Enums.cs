namespace CSharpDemonstration.ObjectOrientation;

public class Enums
{
    public enum Geese{
        EmdenGoose,
        GreylagGoose,
        SwanGoose,
        CanadaGoose
    }

    private static Geese[] geese = { Geese.EmdenGoose, Geese.CanadaGoose, Geese.GreylagGoose, Geese.SwanGoose };
    public static void Main1()
    {
        foreach (var goose in geese)
        {
            string s = goose switch
            {
                Geese.EmdenGoose => "This is a Emden goose",
                Geese.GreylagGoose => "This is a Greylag goose",
                Geese.SwanGoose => "This is a Swan goose",
                _ => "This is an unknown goose"
            };
            Console.WriteLine(s);
        }
    }
}