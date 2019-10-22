using System;
using System.Threading.Tasks;
using codeWarsAPI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace codeWarsAPI.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch(Exception exception)
            {
                await HandleException(httpContext, exception);
            }
        }

        public static Task HandleException(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500;

            return context.Response.WriteAsync(new ErrorMessage()
            {
                StatusCode = context.Response.StatusCode,
                Message = exception.InnerException?.Message ?? exception.Message
            }.ToString());
        }
    }
}
