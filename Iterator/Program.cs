// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Iterator!");

MyCollectionList<string> carBrands = new MyCollectionList<string>();

carBrands.Append("Ferrari");
carBrands.Append("Ford");
carBrands.Append("FIAT");
carBrands.Append("BMW");

IIterator<string> iterator = new ListIterator<string>(carBrands);

Console.WriteLine("1st Iteration");
while (!iterator.IsDone())
{
    Console.WriteLine(iterator.Next());
}

Console.WriteLine("\n2nd Iteration");
while (!iterator.IsDone())
{
    Console.WriteLine(iterator.Next());
}

var iterator1 = carBrands.CreateIterator();
var iterator2 = carBrands.CreateIterator();

Console.WriteLine("\nIndependent Iterators:");
Console.WriteLine($"Iterator 1: {iterator1.Next()}");
Console.WriteLine($"Iterator 1: {iterator1.Next()}");
Console.WriteLine($"Iterator 2: {iterator2.Next()}");
Console.WriteLine($"Iterator 1: {iterator1.Next()}");
Console.WriteLine($"Iterator 1: {iterator1.Next()}");
Console.WriteLine($"Iterator 2: {iterator2.Next()}");

//Generate an InvalidOperationException 
Console.WriteLine($"Iterator 1: {iterator1.Next()}");