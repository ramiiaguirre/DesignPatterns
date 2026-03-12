public class EntityA : ISubscribable
{
    public void Update(IEventManager manager)
    {
        Console.WriteLine("Process in Entity A");
    }
}