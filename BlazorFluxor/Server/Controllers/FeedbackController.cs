using BlazorFluxor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFluxor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        [HttpPost]
        public void Post(UserFeedbackModel model)
        {
            var email = model.EmailAddress;
            var rating = model.Rating;
            var comment = model.Comment;

            Console.WriteLine($"Received rating {rating} from {email} with comment '{comment}'");
        }
    }
}
