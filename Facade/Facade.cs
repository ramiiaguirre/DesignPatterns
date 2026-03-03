using SubsystemA;
using SubsystemB;
public class Facade : IFacade
{
    //It should be better called dependency injection
    DomainSubsystemA _subsystemA = new();
    DomainSubsystemB _subsystemB = new();

    public string GetResultSystemA()
    {
        return _subsystemA.GetResult();
    }
    public string GetResultSystemB()
    {
        return _subsystemB.GetResult();
    }
}