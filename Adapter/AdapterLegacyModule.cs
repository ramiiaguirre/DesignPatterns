using LegacyModuleEncript.From1996; //Adapter knows Legacy Module, the Client doesn't.

namespace AdapterModule;
public class AdapterLegacyModule : ITarget
{
    private readonly LegacyModule _adaptee;

    public AdapterLegacyModule()
    {
        _adaptee = new LegacyModule();
    }

    public string GetRequest()
    {
        return $"Request to legacy module: '{_adaptee.SpecificRequest()}'";
    }
}