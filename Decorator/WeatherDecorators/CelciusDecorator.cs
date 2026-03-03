public class CelciusDecorator : DataDisplayDecorator {
	
	public CelciusDecorator(WeatherData data) : base(data) {}

	public override string DisplayData() {
		return "Temperature C°: " + GetTemperature() + "; " +
		   	    "Pressure: " + GetPressure() + "; " +
		   	    "Solar Radiation: " + GetSolarRadiation() + "; ";		
	}

	public override double GetTemperature() {
		// (ºC = (ºF-32) ÷ 1.8). 
		return (base.GetTemperature() - 32) / 1.8;
	}
	
    public override List<double> GetTemperatures() {
        return base.GetTemperatures()
                    .Select(f => Math.Round((f - 32) / 1.8, 2))
                    .ToList();
    }
}