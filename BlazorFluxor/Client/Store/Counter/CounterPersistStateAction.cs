namespace BlazorFluxor.Client.Store.Counter
{
    public record CounterPersistStateAction
    {
        public CounterState CounterState { get; }
        public CounterPersistStateAction(CounterState counterState)
        {
            CounterState = counterState;
        }
    }
}
