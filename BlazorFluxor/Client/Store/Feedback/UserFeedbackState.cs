using BlazorFluxor.Shared;

namespace BlazorFluxor.Client.Store.Feedback
{
    public record UserFeedbackState
    {
        public bool Submitting { get; init; }
        public bool Submitted { get; init; }
        public string ErrorMessage { get; init; }
        public UserFeedbackModel Model { get; init; }
    }
}
