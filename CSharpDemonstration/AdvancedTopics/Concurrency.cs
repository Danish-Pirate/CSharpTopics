namespace CSharpDemonstration.AdvancedTopics;

public class Concurrency
{
    public static async Task Main(string[] args)
    {
        var tasks = new List<Task<string>>() { GetBankHolidays("https://www.gov.uk/bank-holidays.json") };
        Console.WriteLine("Doing other stuff");
        
        
        await Task.WhenAll(tasks);

        
        string bankHolidaysData = tasks[0].Result;
        Console.WriteLine("Bank Holidays Data:");
        Console.WriteLine(bankHolidaysData);
    }

    static async Task<string> GetBankHolidays(string url)
    {
        using (var httpClient = new HttpClient())
        {
            return await httpClient.GetStringAsync(url);
        }
    }
}