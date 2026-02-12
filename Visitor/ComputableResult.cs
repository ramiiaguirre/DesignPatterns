namespace visitor;

//Concrete Element
public class ComputableResult : IComputable
{
    public int SubTotalSouth { get; set; }
    public int SubTotalNorth { get; set; }
    public int Total() => SubTotalNorth + SubTotalSouth;
    public void Accept(IComputableVisitor visitor)
    {
        visitor.Visit(this); //Double Dispatch
    }
}