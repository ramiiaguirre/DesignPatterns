namespace AbstractFactory;
public abstract class UIFactory
{
    public abstract ButtonUI CreateButton();
    public abstract CardUI CreateCard();
}