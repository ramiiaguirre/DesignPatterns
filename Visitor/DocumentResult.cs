namespace visitor;
//Concrete Element
public class DocumentResult : IComputable
{
    public int PagesCount { get; set; }
    public int WordsCount { get; set; }
    public void Accept(IComputableVisitor visitor)
    {
        visitor.Visit(this); //Double Dispatch
    }
}

