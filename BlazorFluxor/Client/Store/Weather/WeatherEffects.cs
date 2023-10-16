using BlazorFluxor.Client.Store.Counter;
using BlazorFluxor.Shared;
using Fluxor;
using System.Net.Http.Json;

namespace BlazorFluxor.Client.Store.Weather
{
    public class WeatherEffects
    {
        private readonly HttpClient http;
        private readonly IState<CounterState> counterState;

        public WeatherEffects(HttpClient http, IState<CounterState> counterState)
        {
            this.http = http;
            this.counterState = counterState;
        }

        [EffectMethod(typeof(WeatherLoadForecastsAction))]
        public async Task LoadForecasts(IDispatcher dispatcher)
        {
            dispatcher.Dispatch(new WeatherSetLoadingAction(true));
            var forecasts = await http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
            dispatcher.Dispatch(new WeatherSetForecastsAction(forecasts));
            dispatcher.Dispatch(new WeatherSetLoadingAction(false));
        }

        [EffectMethod(typeof(CounterIncrementAction))]
        public async Task LoadForecastsOnIncrement(IDispatcher dispatcher)
        {
            // every tenth increment
            if (counterState.Value.CurrentCount % 10 == 0)
            {
                dispatcher.Dispatch(new WeatherLoadForecastsAction());
            }
        }
    }
}
