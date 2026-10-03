namespace VehicleHierarchyFriend;

public class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, int year)
    {
        Console.WriteLine("Vehicle is being created...");
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine($"The {Brand} vehicle from {Year} is now running.");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        Console.WriteLine("Car is being created...");
        NumberOfDoors = numberOfDoors;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Car: {Brand}, {NumberOfDoors} doors");
    }
}

public class Bus : Vehicle
{
    public int Capacity { get; set; }

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Console.WriteLine("Bus is being created...");
        Capacity = capacity;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Bus: {Brand}, seats {Capacity} passengers");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        Console.WriteLine("Motorcycle is being created...");
        HasSidecar = hasSidecar;
    }

    public void ShowDetails()
    {
        string sidecarStatus = HasSidecar ? "with a sidecar" : "without a sidecar";
        Console.WriteLine($"Motorcycle: {Brand}, {sidecarStatus}");
    }
}

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Making the car:");
        Car familyCar = new("Nissan", 2021, 4);

        Console.WriteLine("\nMaking the bus:");
        Bus schoolBus = new("Volvo", 2019, 52);

        Console.WriteLine("\nMaking the motorcycle:");
        Motorcycle bike = new("Yamaha", 2024, true);

        Console.WriteLine("\nCalling Start() for each vehicle:");
        familyCar.Start();
        schoolBus.Start();
        bike.Start();

        Console.WriteLine("\nShowing the extra details:");
        familyCar.ShowDetails();
        schoolBus.ShowDetails();
        bike.ShowDetails();
    }
}
