using DRE.Api.Entities;

namespace DRE.Api.Data;
public static class DbInitializer
{
    private static readonly string[] _summaries = new[]
    {
       "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public static void Initialize(WeatherDbContext context)
    {
        context.Database.EnsureCreated();

        // Look for any students.
        if (context.Forecasts.Any())
        {
            return;   // DB has been seeded
        }

        var forecasts = Enumerable.Range(1, 5)
            .Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = _summaries[Random.Shared.Next(_summaries.Length)]
            })
            .ToArray();

        foreach (var forecast in forecasts)
        {
            context.Forecasts.Add(forecast);
        }
        context.SaveChanges();
    }
}
