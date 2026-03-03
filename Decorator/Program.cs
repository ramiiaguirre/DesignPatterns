
WeatherData data = new HomeWeatherStation();
Console.WriteLine(data.DisplayData());
foreach (var d in data.GetTemperatures())
{
    Console.WriteLine(d);
}

Console.WriteLine("---");

WeatherData minMaxData = new MinMaxTemperatureDecorator(data);
Console.WriteLine(minMaxData.DisplayData());
foreach (var d in minMaxData.GetTemperatures())
{
    Console.WriteLine(d);
}

Console.WriteLine("---");

WeatherData averageData = new AverageDecorator(minMaxData);
Console.WriteLine(averageData.DisplayData());
foreach (var d in averageData.GetTemperatures())
{
    Console.WriteLine(d);
}

Console.WriteLine("--- Now in Celcius: ");

WeatherData celciusData= new CelciusDecorator(data);
Console.WriteLine(celciusData.DisplayData()); 
foreach (var d in celciusData.GetTemperatures())
{
    Console.WriteLine(d);
}

Console.WriteLine("---");

minMaxData = new MinMaxTemperatureDecorator(celciusData);
Console.WriteLine(minMaxData.DisplayData());
foreach (var d in minMaxData.GetTemperatures())
{
    Console.WriteLine(d);
}

Console.WriteLine("---");

averageData = new AverageDecorator(minMaxData);
Console.WriteLine(averageData.DisplayData());
foreach (var d in averageData.GetTemperatures())
{
    Console.WriteLine(d);
}