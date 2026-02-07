using System.Text;
//RefinedAbstraction
public class PresentationFormalCard : PresentationCard
{
    public PresentationFormalCard(IDisplayPresentation display,
    string name, string job) : base(display, name, job) {}
        
    public override string Display()
    {
        StringBuilder displayString = new StringBuilder();
        displayString.Append(_display.GetHeader(_name));
        displayString.Append(_display.GetContent(_job));
        displayString.AppendLine();        
        return displayString.ToString();
    }
}