namespace Flyweight;

//Flyweight (Intrisic Data)
public class RealStateDeveloper
{
    public Guid ID { get; private set; }
    public CompanyName CompanyName { get; private set; }
    public string Description { get; private set; }
    public decimal Value { get; private set; }
    public string  Address { get; private set; }
    public RealStateDeveloper(CompanyName name, string desc, decimal value, string address)
    {
        ID = Guid.NewGuid();
        CompanyName = name;
        Description = desc;
        Value = value;
        Address = address;
    }    
}

public enum CompanyName
{
    Center,
    West,
    GomezEHijos,
    Cabrera
}