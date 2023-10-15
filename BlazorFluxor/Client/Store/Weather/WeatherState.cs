﻿using BlazorFluxor.Shared;

namespace BlazorFluxor.Client.Store.Weather
{
    public record WeatherState
    {
        public bool Initialized { get; init; }
        public bool Loading { get; init; }
        public WeatherForecast[] Forecasts { get; init; }
    }
}
