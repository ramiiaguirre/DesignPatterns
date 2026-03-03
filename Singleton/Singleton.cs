namespace SingletonSpace;
public class Singleton
{
    private static readonly Dictionary<string, Singleton> _register = new();
    private static string _activeClass = "normal";

    protected Singleton() { }

    // subclasses register
    public static void Register(string nombre, Singleton instancia)
    {
        _register[nombre] = instancia;
    }

    public static void SetClaseActiva(string nombre)
    {
        _activeClass = nombre;
    }

    public static Singleton Instance()
    {
        if (_register.TryGetValue(_activeClass, out var instance))
            return instance;

        throw new InvalidOperationException($"There is no singleton register with name'{_activeClass}'");
    }

    public virtual string StadiumUtility() => string.Empty;

}