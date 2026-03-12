using Mediator;

namespace Servers;

public abstract class Server
{
    protected IMediator? _mediator;

    public Server(IMediator? mediator = null)
    {
        _mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}