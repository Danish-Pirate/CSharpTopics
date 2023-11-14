namespace CSharpDemonstration.MethodsAndErrorHandling;

public class CSharpMethod
{
    public static void Main1(String[] args)
    {
        Console.WriteLine(Test.Sum(5,10,10));
        Console.WriteLine(Test.Sum(2.5F,5.0F,2.5F));

        Test test = new Test();
        string text = "Hello World";
        
        Console.WriteLine(test.RemoveSpace(text));

        int x = 0;
        int x2;
        int x3 = 52;
        
        test.Increment(ref x);
        test.Increment2(out x2);

        Console.WriteLine(x);
        Console.WriteLine(x2);
        test.Increment3(in x3);

        Test t1 = new Test()
        {
            name = "Tom"
        };
        Test t2 = new Test()
        {
            name = "Joe"
        };
        string s = t1 + t2;
        Console.WriteLine(s);
    }

    public class Test
    {
        public string name { get; set; }

        public static string operator +(Test t1, Test t2)
        {
            return t1.name + t2.name;
        }
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static float Sum(params float[] numbers)
        {
            float sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public string RemoveSpace(string s)
        {
            return s.Replace(" ", "");
        }

        public void Increment(ref int i)
        {
            i++;
        }
        
        public void Increment2(out int i)
        {
            i = 0;
            i++;
        }
        public void Increment3(in int i)
        {
            Console.WriteLine(i);
        }
    }
}