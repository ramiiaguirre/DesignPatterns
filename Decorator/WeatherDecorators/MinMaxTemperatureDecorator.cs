public class MinMaxTemperatureDecorator : DataDisplayDecorator 
{
	private double minTemp = double.MaxValue;
    private double maxTemp = double.MinValue;
    
	public MinMaxTemperatureDecorator(WeatherData data) : base(data) 
    {
		foreach (double temp in data.GetTemperatures()) {
            minTemp = Math.Min(minTemp, temp);
            maxTemp = Math.Max(maxTemp, temp);
        }
	}
	
	public override string DisplayData() {
		return base.DisplayData() + "Min: " + this.minTemp + "; Max: " + this.maxTemp + "; ";
	}

}