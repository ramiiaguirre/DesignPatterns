using Flyweight;

class Map
{
    public Map() { }

    public Building CreateBuilding(CompanyName name, string adress, int departmentsCount)
    {
       switch (name)
       {
           case CompanyName.Center:
               return new Building(new RealStateDeveloper(name, "Center RS", 14_585_154.50M, "Av. 7 1547"),
                   adress, departmentsCount);
           case CompanyName.West:
               return new Building(new RealStateDeveloper(name, "West RS", 3_514_100.12M, "Av. 18 57"),
                   adress, departmentsCount);
           case CompanyName.GomezEHijos:
               return new Building(new RealStateDeveloper(name, "Gomez E Hijos", 8_054_977.00M, "Av. 8 1742"),
                   adress, departmentsCount);
           case CompanyName.Cabrera:
               return new Building(new RealStateDeveloper(name, "Cabrera Company", 6_145_896.80M, "Av. 7 1547"),
                  adress, departmentsCount);
           default:
               //Should be null object
               return new Building(new RealStateDeveloper(name, "Center RS", 14_585_154.50M, "Av. 7 1547"),
                   adress, departmentsCount);
       }
    }
}

class MapFlyweight
{
    readonly RealStateDeveloperFactory _realStateFactory;

    public MapFlyweight(RealStateDeveloperFactory factory)
    {
        _realStateFactory = factory;
    }

    public Building CreateBuilding(CompanyName name, string adress, int departmentsCount)
    {
        return new Building(_realStateFactory.Create(name), adress, departmentsCount);
    }
}

class MapFlyweightConcurrent
{
     readonly RealStateDeveloperFactoryConcurrent _realStateFactory;

    public MapFlyweightConcurrent(RealStateDeveloperFactoryConcurrent factory)
    {
        _realStateFactory = factory;
    }

    public Building CreateBuilding(CompanyName name, string adress, int departmentsCount)
    {
        return new Building(_realStateFactory.Create(name), adress, departmentsCount);
    }
}