namespace visitor;

//Visitor Interface
public interface IComputableVisitor
{
    void Visit(ComputableResult element);
    void Visit(DocumentResult element);
}