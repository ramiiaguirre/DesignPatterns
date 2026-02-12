namespace visitor;

public class ExponentialVisitor : IComputableVisitor
{
    public void Visit(ComputableResult element)
    {
        //Do something especific and different on DocumentResult
        element.SubTotalNorth = CalculateExponential(element.SubTotalNorth);
        element.SubTotalSouth = CalculateExponential(element.SubTotalSouth);
    }

    public void Visit(DocumentResult element)
    {
        //Do something especific and different on DocumentResult
        element.PagesCount = CalculateExponential(element.PagesCount);
        element.WordsCount = CalculateExponential(element.WordsCount);
    }

    int CalculateExponential(int number) => number * number;

}
