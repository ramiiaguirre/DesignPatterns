public class SandwichVeggieBuilder : ChefSandwichBuilder 
{	
	internal override void AddBread() {
		this.GetSandwich().Bread = new Ingredient("Seed", 120);
	}

	internal override void AddDressing() {
		this.GetSandwich().Dressing = new NullIngredient();
	}

	internal override void AddMain() {
		this.GetSandwich().Main = new Ingredient("Grilled provolone", 200);
	}

	internal override void AddExtra()
    {
		this.GetSandwich().Extra = new Ingredient("Eggplant", 100);
    }
}