namespace SubsystemB;
internal class DomainSubsystemB
{
    //It should be better called dependency injection
    ServiceB _service = new();

    internal string GetResult()
    {
        return _service.GetComplexResult();
    }
}