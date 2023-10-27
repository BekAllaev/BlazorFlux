using Fluxor;

namespace BlazorFluxor.Client.Store.CounterHub
{
    public static class CounterHubReducers
    {
        [ReducerMethod]
        public static CounterHubState OnSetConnected(CounterHubState state, CounterHubSetConnectedAction action)
        {
            return state with
            {
                Connected = action.connected
            };
        }
    }
}
