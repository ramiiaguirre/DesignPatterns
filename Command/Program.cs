// Program.cs is the Client
using Command;

Console.WriteLine("COMMAND PATTERN");

//TextDocument is Receiver
TextDocument textDocument = new();
textDocument.SetDataContent("Esto es un texto de prueba.");
Console.WriteLine(textDocument.GetDataContent());

ICommand commandSpacer = new SpacerCommand(textDocument);
ICommand commandMayus = new MayusCommand(textDocument);



Console.WriteLine("Add Commands and Execute.");
InvokerCommand invoker = new InvokerCommand();
invoker.AddCommand(commandSpacer);
invoker.Execute();


Console.WriteLine(textDocument.GetDataContent());

Console.WriteLine("Unxecute and clear transactions");
invoker.Unexecute();
Console.WriteLine(textDocument.GetDataContent());

invoker.AddCommand(commandMayus);
invoker.Execute();
Console.WriteLine(textDocument.GetDataContent());
invoker.Unexecute();

Console.WriteLine(textDocument.GetDataContent());
