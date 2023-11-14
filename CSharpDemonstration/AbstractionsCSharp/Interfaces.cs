namespace CSharpDemonstration.AbstractionsCSharp;

public class Interfaces
{
    public static void Main1(string[] args)
    {
        IAnimal animal = new Goose("Tom");
        animal.Sleep();
    }
}

class Goose: IAnimal {
    public string Name { get; set; }

    public Goose(string name)
    {
        Name = name;
    }
    
    void IAnimal.Eat(string foodToEat)
    {
        throw new NotImplementedException();
    }

    void IAnimal.Sleep()
    {
        Console.WriteLine("I sleep at home");
    }
}

interface IAnimal
{
    string Name { get; set; }
    void Eat(string foodToEat);

    void Sleep()
    {
        Console.WriteLine("I sleep anywhere");
    }
}