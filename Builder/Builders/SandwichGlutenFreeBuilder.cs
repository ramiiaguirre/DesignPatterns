public class SandwichGlutenFreeBuilder : ChefSandwichBuilder 
{	
	internal override void AddBread() {
		this.GetSandwich().Bread = new Ingredient("Chipá", 150);
	}

	internal override void AddDressing() {
		this.GetSandwich().Dressing = new Ingredient("Tartar Sauce", 18);
	}

	internal override void AddMain() {
		this.GetSandwich().Main = new Ingredient("Chicken meat", 250);
	}

	internal override void AddExtra() {
		this.GetSandwich().Extra = new Ingredient("Grilled vegetables", 200);
	}
}