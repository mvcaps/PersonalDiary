using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalDiary.Filters
{
    public class SessionAuthentication:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            if(HttpContext.Current.Session["UserId"] == null)
            {
                filterContext.Result = new RedirectResult("~/Home/Index");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}