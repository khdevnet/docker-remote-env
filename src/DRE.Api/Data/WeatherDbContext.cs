namespace DRE.Api.Data;

using Microsoft.EntityFrameworkCore;
using DRE.Api.Entities;

public class WeatherDbContext : DbContext
{
    public WeatherDbContext(DbContextOptions<WeatherDbContext> options) 
    : base(options)
    {
    }

    public DbSet<WeatherForecast> Forecasts { get; set; }
}