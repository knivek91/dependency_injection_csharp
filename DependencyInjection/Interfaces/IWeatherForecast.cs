using System;
using System.Collections.Generic;
using Models;

namespace Interfaces
{
    public interface IWeatherForecast
    {
        DateTime Date { get; set; }
        int TemperatureC { get; set; }
        string Summary { get; set; }
        public IEnumerable<WeatherForecast> GetWeatherForecasts();
    }
}
