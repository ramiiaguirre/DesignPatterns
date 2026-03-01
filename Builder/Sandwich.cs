public class Sandwich
{
    public IIngredient? Bread { get; set; }
    public IIngredient? Dressing { get; set; }
    public IIngredient? Main { get; set; }
    public IIngredient? Extra { get; set; }

    public double CalculetePrice()
        => Bread!.Price + Dressing!.Price + Main!.Price + Extra!.Price;
}