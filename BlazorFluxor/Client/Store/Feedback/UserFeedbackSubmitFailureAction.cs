namespace BlazorFluxor.Client.Store.Feedback
{
    public class UserFeedbackSubmitFailureAction
    {
        public string ErrorMessage { get; }

        public UserFeedbackSubmitFailureAction(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
