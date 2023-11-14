namespace CSharpDemonstration.MethodsAndErrorHandling;

public class ExceptionHandling
{
    public static void Main1(string[] args)
    {
        string s = "25";

        try
        {
            int num = Convert.ToInt32(s);
            Console.WriteLine(num);
        }
        catch (IOException e)
        {
            Console.WriteLine(e);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("This will execute no matter what");
        }
    }
}