namespace Servers;

public class ServerA : Server
{
    public void DoSomething()
    {
        Console.WriteLine("Starts process in server A");
        _mediator!.Notify(this, "SA");
    }
    
    public async Task DoSomethingAsync()
    {
        await Task.Delay(3000);
        Console.WriteLine("Finished async process in server A");
        await _mediator!.Notify(this, "SA");
    }
}
