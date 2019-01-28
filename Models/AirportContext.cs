using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;



namespace RelativityCapstone.Models
{
    public class AirportContext : DbContext
    {
        public AirportContext(DbContextOptions<AirportContext> options)
                : base(options)
            { }
        public DbSet<Runway> Runways { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<WeatherForecast> WeatherForcasts { get; set; }
        public DbSet<WeatherCurrent> CurrentWeather { get; set; }

    }
}

