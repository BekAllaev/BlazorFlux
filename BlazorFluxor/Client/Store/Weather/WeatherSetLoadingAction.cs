namespace BlazorFluxor.Client.Store.Weather
{
    public class WeatherSetLoadingAction
    {
        public bool Loading { get; }

        public WeatherSetLoadingAction(bool loading)
        {
            Loading = loading;
        }
    }
}
