using System.Web.Mvc;

namespace aspnet_mvc_pwa
{
    public class SSLFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsSecureConnection)
            {
                var url = filterContext.HttpContext.Request.Url.ToString().Replace("http:", "https:");
                filterContext.Result = new RedirectResult(url);
            }
        }
    }
}