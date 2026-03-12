namespace Mediator;
public interface IMediator
{
    Task Notify(object sender, string e);
}