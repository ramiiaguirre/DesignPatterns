namespace SingletonSpace;
public class StadiumServer : Singleton
{
    private static readonly StadiumServer _instancia = new();

    static StadiumServer()
    {
        Register("normal", _instancia);
    }

    public override string StadiumUtility() => "stadium server";
}