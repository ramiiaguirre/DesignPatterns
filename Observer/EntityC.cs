public class EntityC : ISubscribable
{
     public void Update(IEventManager manager)
    {
        if (manager.GetState() > 1)
            Console.WriteLine($"Process in Entity C - State: {manager.GetState()}");
    }
}