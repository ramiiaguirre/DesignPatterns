namespace Composite;

//Component
public abstract class Topography 
{
	public abstract double GetWaterRatio();
	
	public double GetLandRatio()
	{
		return 1 - this.GetWaterRatio();
	}

	//code equals
}