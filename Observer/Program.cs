IEventManager manager = new EventManager();

var subs1 = new EntityA();
manager.AddSubscriber(subs1);

var subs2 = new EntityB();
manager.AddSubscriber(subs2);

var subs3 = new EntityC();
manager.AddSubscriber(subs3);

manager.SomeBusinessLogic();
manager.SomeBusinessLogic();
manager.SomeBusinessLogic();
manager.SomeBusinessLogic();


System.Console.WriteLine();
System.Console.WriteLine("---- Remove Entity B -----");
manager.RemoveSubscriber(subs2);
manager.SomeBusinessLogic();