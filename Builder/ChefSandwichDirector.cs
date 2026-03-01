public class ChefSandwichDirector
{
    private ChefSandwichBuilder builder;
	
	public ChefSandwichDirector(ChefSandwichBuilder builder) {
		this.builder = builder;
	}
	
	public void SetChefBuilder(ChefSandwichBuilder builder) {
		this.builder = builder;
	}
	
	public ChefSandwichBuilder MakeSandwich() {

        // If you need to have other steps sequence, you need to add other director class.
        // Ex: A Director that like add first the Main and Extra ingredients, then the dressing.
		this.builder.ResetSandwich();
		this.builder.AddBread();
		this.builder.AddDressing();
		this.builder.AddMain();
		this.builder.AddExtra();

		return builder;
	}
}