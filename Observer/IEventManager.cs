public interface IEventManager
{
    int GetState();
    public void AddSubscriber(ISubscribable subscriber);
    public void RemoveSubscriber(ISubscribable subscriber);
    public void NotifySubscribers();

    public void SomeBusinessLogic();
}