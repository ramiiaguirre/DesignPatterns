//Shallow
Robot AP235 = new Robot("Robot specialized in space exploration");
Console.WriteLine(AP235.ToString());
AP235.Execute();
AP235.Execute();
Robot AP300 = AP235.Clone() as Robot;
AP300.Execute();
Console.WriteLine(AP235.ToString());
Console.WriteLine(AP300.ToString());
Console.WriteLine("Is it the same Robot? => " + (AP235 == AP300));

IASubagent IACodeSessionA = new IASubagent();
IASubagent IACodeSessionB = IACodeSessionA.Clone() as IASubagent;
Console.WriteLine(IACodeSessionA.ToString());
Console.WriteLine(IACodeSessionB!.ToString());
Console.WriteLine("Is it the same IA Session? => " + (IACodeSessionA == IACodeSessionB));

//Deep
ComplexRobot cRobot = new ComplexRobot("Fast robot specialized in space exploration");
System.Console.WriteLine(cRobot.ToString());

ComplexRobot cRobot2 = cRobot.Clone() as ComplexRobot;
System.Console.WriteLine(cRobot2.ToString());

System.Console.WriteLine($"Is it the same Engine? => {cRobot.Engine == cRobot2.Engine}");
