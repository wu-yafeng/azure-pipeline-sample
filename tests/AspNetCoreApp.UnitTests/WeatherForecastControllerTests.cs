using AspNetCoreApp.Application;
using AspNetCoreApp.Controllers;
using MyTested.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AspNetCoreApp.UnitTests
{
    public class WeatherForecastControllerTests
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [Fact]
        public void GetShouldReturnWeatherForecast()
            => MyMvc.Controller<WeatherForecastController>(instance => instance.WithData(context => context.WithEntities<WeatherForecastContext>(FakeWeatherForecast())))
                .Calling(controller => controller.Get())
                .ShouldReturn();

        private IEnumerable<WeatherForecast> FakeWeatherForecast()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Id = index,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
