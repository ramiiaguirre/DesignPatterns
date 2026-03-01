public class Robot : IClonable
{
    public Guid ID { get; }
    public int Energy { get; private set; }
    public string? Description { get; set; }

    public Robot(string description)
    {
        ID = Guid.NewGuid();
        Energy = 100;
        Description = description;
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
        return (IClonable)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Robot: ID[{ID}] - Energy[{Energy}]";
    }
}