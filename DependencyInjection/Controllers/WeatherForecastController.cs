using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        #region Variables
        private readonly IWeatherForecast _weatherForecast;
        #endregion

        #region Constructor
        public WeatherForecastController(IWeatherForecast weatherForecast)
        {
            _weatherForecast = weatherForecast;
        }
        #endregion

        #region Get Methods
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecast.GetWeatherForecasts();
        }
        [HttpGet("[action]")]
        public string GetCurrentTime([FromServices] ICurrentDateTime currentDateTime)
        {
            return $"Current server time: {currentDateTime.Now.ToLongTimeString()}";
        }
        #endregion

    }
}
