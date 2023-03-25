namespace DRE.Api.Entities
{
    public class WeatherForecast
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; } //=> 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}