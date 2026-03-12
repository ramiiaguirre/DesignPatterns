using Servers;
using Mediator;

ServerA serverA = new ServerA();
ServerB serverB = new ServerB();

new MediatorImpl(serverA, serverB);

System.Console.WriteLine("Server A do something from Program.cs - First step");
serverA.DoSomething();

System.Console.WriteLine("Server B do something from Program.cs - Second step");
await serverB.DoSomethingWithExternalServers();