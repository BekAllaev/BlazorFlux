using BlazorFluxor.Shared;
using Fluxor;

namespace BlazorFluxor.Client.Store.Feedback
{
    public class UserFeedbackFeature : Feature<UserFeedbackState>
    {
        public override string GetName() => "UserFeedback";

        protected override UserFeedbackState GetInitialState()
        {
            return new UserFeedbackState
            {
                Submitting = false,
                Submitted = false,
                ErrorMessage = string.Empty,
                Model = new UserFeedbackModel()
            };
        }
    }
}
