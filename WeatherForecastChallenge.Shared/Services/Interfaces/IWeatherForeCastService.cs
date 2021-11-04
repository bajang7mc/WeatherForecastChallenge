using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherForecastChallenge.Shared.Models;

namespace WeatherForecastChallenge.Shared.Services.Interfaces
{
    public interface IWeatherForeCastService
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecasts();
        Task<IEnumerable<WeatherForecast>> GetWeatherForecasts(string summary);
    }
}
