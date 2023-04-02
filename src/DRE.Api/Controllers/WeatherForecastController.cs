using DRE.Api.Data;
using DRE.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DRE.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherDbContext _db;

        public WeatherForecastController(WeatherDbContext db) => _db = db;

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _db.Forecasts.ToArray();
        }
    }
}