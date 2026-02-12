using visitor;
Console.WriteLine("VISITOR!");

ComputableResult computable = new ComputableResult()
{
    SubTotalSouth = 48,
    SubTotalNorth = 410
};

Console.WriteLine("The total of computable is: " + computable.Total());

DocumentResult document = new DocumentResult()
{
    WordsCount = 1544,
    PagesCount = 4
};

Console.WriteLine("The count words on the document is: " + document.WordsCount);
Console.WriteLine("\nExponential process!");

var elements = new List<IComputable>();
elements.Add(computable);
elements.Add(document);

foreach (var element in elements)
{
    element.Accept(new ExponentialVisitor());
}

Console.WriteLine("The total of computable is: " + computable.Total());
Console.WriteLine("The count words on the document is: " + document.WordsCount);


Console.WriteLine("\nOctal process!");

foreach (var element in elements)
{
    element.Accept(new OctalVisitor());
}

Console.WriteLine("The total of computable is: " + computable.Total());
Console.WriteLine("The count words on the document is: " + document.WordsCount);