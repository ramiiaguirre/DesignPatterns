using Flyweight;
using System.Collections.Concurrent;

const int COUNT_REGISTERS = 100_000_000;

// Without Flyweight Pattern
//ProcessWithoutFlyweight(COUNT_REGISTERS);

// With Flyweight Pattern
//ProcessWithFlyweight(COUNT_REGISTERS);


// With Flyweight Pattern and Concurrence
ProcessWithFlyweightConcurrent(COUNT_REGISTERS);


Console.ReadKey();

void ProcessWithoutFlyweight(int repeat)
{
    Map map = new Map();

    List <Building> buildings = new List<Building>();

    for (int i = 0; i < repeat; i++)
    {
        Building building = map.CreateBuilding(GetRandomCompanyName(), "adress and number building", 15);
        buildings.Add(building);
    }
}

void ProcessWithFlyweight(int repeat)
{
    MapFlyweight map = new MapFlyweight(new RealStateDeveloperFactory());

    List <Building> buildings = new List<Building>();

    for (int i = 0; i < repeat; i++)
    {
        Building building = map.CreateBuilding(GetRandomCompanyName(), "adress and number building", 15);
        buildings.Add(building);
    }
}

async void ProcessWithFlyweightConcurrent(int reapeat)
{
    MapFlyweightConcurrent map = new MapFlyweightConcurrent(new RealStateDeveloperFactoryConcurrent());
    ConcurrentBag<Building> buildings = new ConcurrentBag<Building>();
    Parallel.For(0, COUNT_REGISTERS, i =>
    {
        CompanyName name = GetRandomCompanyName();
        Building building = map.CreateBuilding(name, "adress and number building", 15);
        buildings.Add(building);
    });
}

CompanyName GetRandomCompanyName()
{
    var values = Enum.GetValues(typeof(CompanyName));
    var random = new Random();
    return (CompanyName)values.GetValue(random.Next(values.Length))!;
}