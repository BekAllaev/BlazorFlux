using BlazorFluxor.Shared;

namespace BlazorFluxor.Client.Store.Weather
{
    public class WeatherSetForecastsAction
    {
        public WeatherForecast[] Forecasts { get; }

        public WeatherSetForecastsAction(WeatherForecast[] forecasts)
        {
            Forecasts = forecasts;
        }
    }
}
