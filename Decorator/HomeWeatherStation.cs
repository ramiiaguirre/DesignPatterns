//Concrete Component
public class HomeWeatherStation : WeatherData {
	
	//Fahrenheit. 
	public double GetTemperature() {
		return 86.0;
	}

	//hPa
	public double GetPressure() {
		return 1008;
	}

	public double GetSolarRadiation() {
		return 200.0;
	}

	//Fahrenheit. 
	public List<double> GetTemperatures() {
		List<double> data = new List<double>();
		data.Add(75.8);
        data.Add(85.1);
		data.Add(78.4);
		return data;
	}

	//return a report with all data
	public string DisplayData(){
		return "Temperature F°: " + GetTemperature() + "; " +
		   	  "Pressure: " + GetPressure() + "; " +
		   	  "Solar Radiation: " + GetSolarRadiation() + "; ";
	}

}
