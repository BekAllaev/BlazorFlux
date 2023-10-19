namespace BlazorFluxor.Client.Store.Counter
{
    public record CounterPersistStateFailureAction
    {
        public string ErrorMessage { get; }
        public CounterPersistStateFailureAction(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
