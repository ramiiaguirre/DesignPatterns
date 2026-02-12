namespace visitor;

//Element Interface
public interface IComputable
{
    public void Accept(IComputableVisitor visitor); 
}
