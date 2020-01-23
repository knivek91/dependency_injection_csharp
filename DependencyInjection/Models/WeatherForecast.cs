using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;

namespace Models
{
    public class WeatherForecast : IWeatherForecast
    {

        #region Variable
        ICurrentDateTime _currentDateTime;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        #endregion

        #region Contructor
        public WeatherForecast() { }

        public WeatherForecast(ICurrentDateTime currentDateTime)
        {
            _currentDateTime = currentDateTime;
        }
        #endregion

        #region Getter/Setter
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
        #endregion

        #region IWeatherForecast Implementation
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = _currentDateTime.Now.AddDays(index), // using ICurrentDateTime reference
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        #endregion
    }
}
