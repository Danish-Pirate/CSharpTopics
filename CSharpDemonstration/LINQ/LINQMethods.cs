namespace CSharpDemonstration.LINQ;

public class LINQMethods
{
    public static void Main1(string[] args)
    {
        IList<string> nameList = new List<string> { "Tony", "Joey", "Jonas", "Thomas", "Ron" };
        //var filteredNames = nameList.Where((s) => s.Length <= 4 && s.EndsWith("y"));
        var filteredNames = 
            from name in nameList
            where name.Length <= 4 && name.EndsWith("y")
            select name;
        
        filteredNames.ToList().ForEach(Console.WriteLine);
    }
}