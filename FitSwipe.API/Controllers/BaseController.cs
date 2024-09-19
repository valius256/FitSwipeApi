using Microsoft.AspNetCore.Mvc;

namespace FitSwipe.API.Controllers
{
    public class BaseController<T> : Controller
    {
        protected readonly ILogger<T> _logger;

        public BaseController(ILogger<T> logger)
        {
            _logger = logger;
        }

        protected string? CurrentUserFirebaseId
        {
            get
            {
                var firebaseId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "user_id")?.Value;
                if (firebaseId != null)
                {
                    return firebaseId;
                }
                _logger.LogInformation("Can't get user from HttpContext");
                return null;
            }
        }
    }
}
