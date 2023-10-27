using Fluxor;

namespace BlazorFluxor.Client.Store.CounterHub
{
    public class CounterHubFeature : Feature<CounterHubState>
    {
        public override string GetName() => "CounterHub";

        protected override CounterHubState GetInitialState()
        {
            return new CounterHubState
            {
                Connected = false
            };
        }
    }
}
