using citytransportAPI.Cache;
using Microsoft.AspNetCore.Mvc.Filters;

namespace citytransportAPI.Filters
{
    public class SessionUsage : ActionFilterAttribute
    {
        private readonly SessionCache _sessionCache;

        public SessionUsage(SessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _sessionCache.SaveSessionItems();

            base.OnActionExecuted(context);
        }
    }
}