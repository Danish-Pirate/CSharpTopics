namespace CSharpDemonstration.ObjectOrientation;

public class Classes
{
    public static void Main1(string[] args)
    {
        Goose goose = new Goose(true, 25);
        goose.MakeNoise();
        Cat cat1 = new Cat("Whiskers", 3);
        Cat cat2 = cat1 with { Age = 4 };
    }
}

class Goose : Mammal
{
    public readonly bool CanFly;

    public Goose(bool canFly, int weight): base(weight)
    {
        CanFly = canFly;
    }
    public override void MakeNoise()
    {
        Console.WriteLine("Honk");
    }
}
struct Dog {}
record Cat(string Name, int Age) {}

interface IAnimal
{
    public void MakeNoise();
}

class Mammal : IAnimal
{
    private float _weight;

    public float Weight
    {
        get => _weight;
        set => _weight = value;
    }

    public Mammal(float weight)
    {
        Weight = weight;
    }
    
    public virtual void MakeNoise()
    {
        Console.WriteLine("Animal noises");
    }
}