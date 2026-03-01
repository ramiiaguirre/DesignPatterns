public abstract class ChefSandwichBuilder
{
    private Sandwich? Sandwich;
	
	public void ResetSandwich() {
		this.Sandwich = new Sandwich();
	}
	
	public Sandwich GetSandwich() {
		return this.Sandwich!;
	}
	
	internal abstract void AddBread();
	internal abstract void AddDressing();
	internal abstract void AddMain();
	internal abstract void AddExtra();
    
}