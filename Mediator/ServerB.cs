using System.Threading.Tasks;

namespace Servers;
public class ServerB : Server
{
    public async Task DoSomethingWithExternalServers()
    {
        Console.WriteLine("Started process in server B with external servers");
        await _mediator!.Notify(this, "SB");
    }

    public async Task DoSomethingAsync()
    {
        Console.WriteLine("Started async process in server B");
        await Task.Delay(2000);
        Console.WriteLine("Finished async process in server B");
    }

}