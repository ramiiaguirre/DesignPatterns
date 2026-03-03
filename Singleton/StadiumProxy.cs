namespace SingletonSpace;
public class StadiumProxy : Singleton
{
    private static readonly StadiumProxy _instancia = new();

    static StadiumProxy()
    {
        Register("proxy", _instancia);
    }

    public override string StadiumUtility() => "stadium proxy";
}