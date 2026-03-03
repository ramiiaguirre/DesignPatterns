//Component
public interface WeatherData 
{
	public double GetTemperature();

	public double GetPressure();

	public double GetSolarRadiation();

	public List<double> GetTemperatures();

	public string DisplayData();

}