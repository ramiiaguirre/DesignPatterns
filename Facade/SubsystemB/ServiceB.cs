namespace SubsystemB;
class ServiceB
{
    public string GetComplexResult()
    {
        return Guid.NewGuid().ToString();
    }
    
}