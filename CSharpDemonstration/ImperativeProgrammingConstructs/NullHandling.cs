using System.Runtime.InteropServices.ComTypes;

namespace CSharpDemonstration.ImperativeProgrammingConstructs;

public class NullHandling
{
    static void Main1(string[] args)
    {
        List<Customer> customerList = new List<Customer>();
        customerList.Add(new Customer(1, "Tom"));
        customerList.Add(new Customer(2, "Johnathan", "Maple Street 41"));

        foreach (Customer customer in customerList)
        {
            Console.Write($"ID: {customer.CustomerId} Name: {customer.CustomerName} ");
            Console.WriteLine(customer.CustomerAddress ?? string.Empty);

            if (customer.CustomerAddress is null)
                Console.WriteLine(string.Empty);
            

            /*
            if (customer.CustomerAddress == null)
                Console.WriteLine(string.Empty);
            */

            _ = customer.CustomerAddress ?? throw new ArgumentNullException(nameof(customer.CustomerAddress));


        }
        
        Customer? customer1 = null;
        string customerAddress = customer1.CustomerAddress ?? String.Empty;
        ArgumentNullException.ThrowIfNull(customer1);
        
    }

    public class Customer
    {
        public int CustomerId { get; }
        public string CustomerName { get; }
        public string? CustomerAddress { get;}

        public Customer(int customerId, string customerName, string? customerAddress = null)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
        }
    }
}