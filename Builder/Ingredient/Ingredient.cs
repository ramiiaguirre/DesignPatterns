public class Ingredient : IIngredient
{
    public string Name { get; }
    public double Price { get; }

    public Ingredient(string name, double price)
    {
        Name = name;
        Price = price;
    }
}