namespace WebApplication1;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public string? NewProperty1 { get; set; }

    public string? NewProperty2 { get; set; }

    public string? NewProperty3 { get; set; }

    public string? NewProperty4 { get; set; }

    public string? NewPropertynewadded { get; set; }

    public string? NewPropertynew { get; set; }

    public string? NewPropertynew1 { get; set; }

    
    public string? NewPropertynew2 { get; set; }


}
