using BlazorFluxor.Shared;

namespace BlazorFluxor.Client.Store.Feedback
{
    public class UserFeedbackSubmitAction
    {
        public UserFeedbackModel UserFeedbackModel { get; }

        public UserFeedbackSubmitAction(UserFeedbackModel userFeedbackModel)
        {
            UserFeedbackModel = userFeedbackModel;
        }
    }
}
