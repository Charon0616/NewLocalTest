using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            NewProperty1 = Summaries[Random.Shared.Next(Summaries.Length)],
            NewProperty2 = Summaries[Random.Shared.Next(Summaries.Length)],
            NewProperty3 = Summaries[Random.Shared.Next(Summaries.Length)],
            NewProperty4 = Summaries[Random.Shared.Next(Summaries.Length)],
            NewPropertynewadded = Summaries[Random.Shared.Next(Summaries.Length)],
            NewPropertynew = Summaries[Random.Shared.Next(Summaries.Length)],
            NewPropertynew1 = Summaries[Random.Shared.Next(Summaries.Length)],
        })
        .ToArray();
    }
}
