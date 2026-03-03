namespace SubsystemA;
class ServiceA
{
    public string GetComplexResult()
    {
        return Guid.NewGuid().ToString();
    }
    
}