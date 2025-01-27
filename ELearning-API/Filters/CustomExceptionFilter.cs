using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ELearning_API.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // Log the exception (optional)
            Console.WriteLine($"Exception caught: {context.Exception.Message}");

            // Set a custom response
            context.Result = new JsonResult(new
            {
                Message = "An error occurred while processing your request.",
                Error = context.Exception.Message
            })
            {
                StatusCode = 500 // Internal Server Error
            };

            context.ExceptionHandled = true; // Mark the exception as handled
        }
    }
}
