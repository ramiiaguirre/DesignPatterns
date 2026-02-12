namespace visitor;
public class OctalVisitor : IComputableVisitor
{
    public void Visit(ComputableResult element)
    {
        //Do something especific and different on Computable
        element.SubTotalNorth = Convert.ToInt32(GenerateOctalNumber(element.SubTotalNorth));
        element.SubTotalSouth = Convert.ToInt32(GenerateOctalNumber(element.SubTotalSouth));
    }

    public void Visit(DocumentResult element)
    {
        //Do something especific and different on DocumentResult
        element.PagesCount = Convert.ToInt32(GenerateOctalNumber(element.PagesCount));
        element.WordsCount = Convert.ToInt32(GenerateOctalNumber(element.WordsCount));
    }

    string GenerateOctalNumber(int number) => Convert.ToString(number, 8);
}
