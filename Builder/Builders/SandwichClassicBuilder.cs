public class SandwichClassicBuilder : ChefSandwichBuilder 
{	
	internal override void AddBread() {
		this.GetSandwich().Bread = new Ingredient("Brioche", 100);
	}

	internal override void AddDressing() {
		this.GetSandwich().Dressing = new Ingredient("mayo", 20);
	}

	internal override void AddMain() {
		this.GetSandwich().Main = new Ingredient("Beef", 300);
	}

	internal override void AddExtra() {
		this.GetSandwich().Extra = new Ingredient("tomatoe", 80);
	}
}