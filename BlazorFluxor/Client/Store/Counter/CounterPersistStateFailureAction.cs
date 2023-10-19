namespace BlazorFluxor.Client.Store.Counter
{
    public class CounterPersistStateFailureAction
    {
        public string ErrorMessage { get; }
        public CounterPersistStateFailureAction(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
