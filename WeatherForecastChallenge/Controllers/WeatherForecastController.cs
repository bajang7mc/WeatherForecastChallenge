using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherForecastChallenge.Shared;
using WeatherForecastChallenge.Shared.Models;

namespace WeatherForecastChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> GetAll()
        {
            return await new WeatherForeCastService().GetWeatherForecasts();
        }

        [HttpGet("{summary}")]
        public async Task<IEnumerable<WeatherForecast>> GetByFilter(string summary)
        {
            _logger.LogInformation(summary);
            return await new WeatherForeCastService().GetWeatherForecasts(summary);
        }
    }
}