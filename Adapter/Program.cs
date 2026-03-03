using AdapterModule;

ITarget adapter = new AdapterLegacyModule();
System.Console.WriteLine(adapter.GetRequest());