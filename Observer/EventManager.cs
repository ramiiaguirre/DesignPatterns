
//Subject - Publisher - Notifier
public class EventManager : IEventManager
{

    //Observers
    List<ISubscribable> _subscribers;
    int _state;

    public EventManager()
    {
        _subscribers = new List<ISubscribable>();
    }
    
    public int GetState()
    {
        return _state;
    }

    public void AddSubscriber(ISubscribable subscriber)
    {
        Console.WriteLine("Subject: Attached an observer.");
        _subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(ISubscribable subscriber)
    {
        _subscribers.Remove(subscriber);
        Console.WriteLine("Subject: Detached an observer.");
    }

    public void NotifySubscribers()
    {
        Console.WriteLine("Subject: Notifying observers...");
        _subscribers.ForEach(s => s.Update(this));
    }
    

    public void SomeBusinessLogic()
    {
        Console.WriteLine("\nSubject: I'm doing something important.");
        _state = new Random().Next(0,3);

        Thread.Sleep(15);

        Console.WriteLine("Subject: My state has just changed to: " + _state);
        NotifySubscribers();
    }


}