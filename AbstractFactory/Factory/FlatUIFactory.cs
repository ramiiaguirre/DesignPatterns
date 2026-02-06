namespace AbstractFactory;
public class FlatUIFactory : UIFactory
{
    public override ButtonUI CreateButton()
    {
        return new FlatButtonUI();
    }
     public override CardUI CreateCard()
    {
        return new FlatCardUI();
    }
}
