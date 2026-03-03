namespace SubsystemA;
internal class DomainSubsystemA
{
    //It should be better called dependency injection
    ServiceA _service = new();

    internal string GetResult()
    {
        return _service.GetComplexResult();
    }
}