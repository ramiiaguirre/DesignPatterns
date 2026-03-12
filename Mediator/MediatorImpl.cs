
using Servers;

namespace Mediator;

public class MediatorImpl : IMediator
{
    ServerA _serverA;
    ServerB _serverB;

    public MediatorImpl(ServerA serverA, ServerB serverB)
    {
        _serverA = serverA;
        _serverA.SetMediator(this);

        _serverB = serverB;
        _serverB.SetMediator(this);
    }

    public async Task Notify(object sender, string e)
    {
        if (e == "SA")
            await _serverB.DoSomethingAsync();

        if (e == "SB")
            await _serverA.DoSomethingAsync();
    }
}