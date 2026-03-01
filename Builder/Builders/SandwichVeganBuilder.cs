public class SandwichVeganBuilder : ChefSandwichBuilder 
{	
	internal override void AddBread() {
		this.GetSandwich().Bread = new Ingredient("Wholemeal", 100);
	}

	internal override void AddDressing() {
		this.GetSandwich().Dressing = new Ingredient("Creole Sauce", 20);
	}

	internal override void AddMain() {
		this.GetSandwich().Main = new Ingredient("Breaded oyster mushroom cutlet", 500);
	}

	internal override void AddExtra() {
		this.GetSandwich().Extra = new NullIngredient();
	}
}