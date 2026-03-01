public class IASubagent : IClonable
{
    public Guid ID { get; private set;} = Guid.NewGuid();
    public string? Description { get; set; }
    public string? Session { get; private set; }
    public IClonable Clone()
    {
        var clone = (IASubagent)this.MemberwiseClone();
        //Logic for object identity
        clone.ID = Guid.NewGuid();
        return clone;
    }

    public override string ToString()
    {
        return $"Subagent ID[{ID}]";
    }
}