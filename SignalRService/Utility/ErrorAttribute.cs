using Easy.Public.MyLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http.Filters;

namespace Easy.Register
{
    /// <summary>
    /// 错误处理
    /// </summary>
    public class ErrorAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var url = actionExecutedContext.Request.RequestUri.ToString();
            var ex = actionExecutedContext.Exception;

            LogManager.Error(url, ex.Message + ex.StackTrace);
        }
    }
}