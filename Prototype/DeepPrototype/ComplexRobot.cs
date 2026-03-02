public class ComplexRobot : IClonable
{
    public Guid ID { get; }
    public int Energy { get; private set; }
    public string? Description { get; set; }
    public Engine Engine { get; set; }

    public ComplexRobot(string description)
    {
        ID = Guid.NewGuid();
        Energy = 100;
        Description = description;
        Engine = new Engine("V8 Space Explorer");
    }

    public void ChargeEnergy()
    {
        if(Energy < 100)
            Energy++;
    }

    public void Execute()
    {
        if(Energy > 0)
            Energy--;
    }
    
    public IClonable Clone()
    {
        //Deep clone
        var clone = (ComplexRobot)this.MemberwiseClone();
        clone.Engine = new Engine(this.Engine.Model);
        return clone;
        //return (IClonable)this.MemberwiseClone(); // ERROR: return the object Engine reference
    }

    public override string ToString()
    {
        return $"Robot: ID[{ID}] - Energy[{Energy}] - Engine[{Engine.Model}]";
    }
}