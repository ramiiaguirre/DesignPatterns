namespace Composite;
public abstract class Topography 
{
	public abstract double GetWaterProportion();
	public double GetLandProportion()
	{
		return 1 - this.GetWaterProportion();
	}

	//code equals
}