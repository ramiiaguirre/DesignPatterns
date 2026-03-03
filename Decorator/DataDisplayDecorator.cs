//Decorator
public class DataDisplayDecorator : WeatherData 
{
	WeatherData Data;
	
	public DataDisplayDecorator(WeatherData data) {
		Data = data;
	}
	
	public virtual double GetTemperature() {
		return Data.GetTemperature();
	}

	public virtual double GetPressure() {
		return Data.GetPressure();
	}

	public virtual double GetSolarRadiation() {
		return Data.GetSolarRadiation();
	}

	public virtual List<double> GetTemperatures() {
		return Data.GetTemperatures();
	}
	public virtual string DisplayData() {
		return Data.DisplayData();
	}

}