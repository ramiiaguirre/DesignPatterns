namespace AbstractFactory;
public class LiquidUIFactory : UIFactory
{
    public override ButtonUI CreateButton()
    {
        return new LiquidButtonUI();
    }

     public override CardUI CreateCard()
    {
        return new LiquidCardUI();
    }
}