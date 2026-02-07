//Abstraction
public abstract class PresentationCard
{
    internal IDisplayPresentation _display;
    internal string _name;
    internal string _job;

    public PresentationCard(IDisplayPresentation display, string name, string job)
    {
        _display = display;
        _name = name;
        _job = job;
    }

    public abstract string Display();
}