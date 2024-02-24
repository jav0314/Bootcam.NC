using Bootcam.NC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace Bootcam.NC.Controllers
{
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

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    DateTime Timer = new DateTime(2003, 10, 03);
        //    return Enumerable.Range(1, 5).Select((index) => FuncionPrueba(index))
        //    .ToArray();
        //}

        //    WeatherForecast FuncionPrueba(int index)
        //    {
        //        return new WeatherForecast
        //        {
        //            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //            TemperatureC = Random.Shared.Next(-20, 55),
        //            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
        //            Name = "Hola"
        //        };
        //    }        
    }
}
