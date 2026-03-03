public class AverageDecorator : DataDisplayDecorator {

	public AverageDecorator(WeatherData data) : base(data) {}
	
    private double CalculateAverageTemperatures() {
        // List<double> temperatures = base.GetTemperatures();
        // double sum = 0.0;
        // foreach (var t in temperatures)
        // {
        //     sum += t;
        // }
        // return sum / temperatures.Count;
        return GetTemperatures().Average();
	}

	public override string DisplayData() {
		return base.DisplayData() + "Average: " + this.CalculateAverageTemperatures() + "; ";
		
	}

}