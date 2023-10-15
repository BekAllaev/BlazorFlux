using BlazorFluxor.Shared;
using Fluxor;
using System.Net.Http.Json;

namespace BlazorFluxor.Client.Store.Weather
{
    public class WeatherEffects
    {
        private readonly HttpClient Http;

        public WeatherEffects(HttpClient http)
        {
            Http = http;
        }

        [EffectMethod(typeof(WeatherLoadForecastsAction))]
        public async Task LoadForecasts(IDispatcher dispatcher)
        {
            dispatcher.Dispatch(new WeatherSetLoadingAction(true));
            var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
            dispatcher.Dispatch(new WeatherSetForecastsAction(forecasts));
            dispatcher.Dispatch(new WeatherSetLoadingAction(false));
        }
    }
}
