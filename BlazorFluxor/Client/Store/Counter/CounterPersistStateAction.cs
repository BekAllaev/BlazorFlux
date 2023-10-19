namespace BlazorFluxor.Client.Store.Counter
{
    public class CounterPersistStateAction
    {
        public CounterState CounterState { get; }
        public CounterPersistStateAction(CounterState counterState)
        {
            CounterState = counterState;
        }
    }
}
