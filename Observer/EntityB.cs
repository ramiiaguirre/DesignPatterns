public class EntityB : ISubscribable
{
    public void Update(IEventManager manager)
    {
        if (manager.GetState() > 0)
            Console.WriteLine($"Process in Entity B - State: {manager.GetState()}");
    }
}