using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Application
{
    public class WeatherForecastContext : DbContext
    {
        public WeatherForecastContext(DbContextOptions<WeatherForecastContext> options) : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyToWeatherForecast(modelBuilder.Entity<WeatherForecast>());
            base.OnModelCreating(modelBuilder);
        }

        private void ApplyToWeatherForecast(EntityTypeBuilder<WeatherForecast> builder)
        {
            builder.Ignore(entity => entity.TemperatureF);
        }
    }
}
