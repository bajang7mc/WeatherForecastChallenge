# WeatherForecastChallenge

- Using .NET Core 3.1 (Linux, macOS, and Windows)

API to get the weather forcasts
 - GetWeatherForecasts() --> https://localhost:5001/weatherforecast
 - GetWeatherForecasts(summary) --> https://localhost:5001/weatherforecast/chilly
   filter by summary which summary list is ("Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching")
   that returns type should be IEnumerable<WeatherForecast> or empty.


# TODO:
- Refactoring code.
- Implement method filter with summary from GetWeatherForecasts service.
- Add unit testing.

## You can:
- Re-structures the codebase.
- Create new classes/ modules /methods.
- Modify existing code.

## You can't:
- Change existing behaviors.
- Change return type of methods.
- Install more library than those already in the NuGet.

## Bonus:
- Use Logger to log somethings.
- Validate input of GetWeatherForecasts(summary) method.

##Hint:
- Good luck Have fun!!
