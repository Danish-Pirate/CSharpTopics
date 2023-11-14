namespace CSharpDemonstration.MethodsAndErrorHandling;

public class TuplesAndDeconstructors
{
    public static void Main(string[] args)
    {
        Building building = new Building(50, 100, "Tom Tower");
        var (height, width, name) = building;
        Console.WriteLine($"{height} {width} {name}");
        
        Console.WriteLine(building.Dimensions());
    }

    public class Building
    {
        public int HeightInMeters { get; }
        public int WidthInMeters { get; }
        public string BuildingName { get; }

        public Building(int heightInMeters, int widthInMeters, string buildingName)
        {
            HeightInMeters = heightInMeters;
            WidthInMeters = widthInMeters;
            BuildingName = buildingName;
        }

        public void Deconstruct(out int heightInMeters, out int widthInMeters, out string buildingName)
        {
            heightInMeters = HeightInMeters;
            widthInMeters = WidthInMeters;
            buildingName = BuildingName;
        }

        public (int, int) Dimensions()
        {
            return (HeightInMeters, WidthInMeters);
        }
    }
}