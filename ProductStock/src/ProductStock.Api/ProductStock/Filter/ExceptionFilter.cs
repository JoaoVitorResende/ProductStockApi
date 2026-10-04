using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductStock.Communication.Response;
using ProductStock.Exception.ExceptionBase;

namespace ProductStock.Filter
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ProductStockException)
            {
                HandleProjectException(context);
            }
            else
            {
                ThrowUnknownError(context);
            }
        }

        private void HandleProjectException(ExceptionContext context)
        {
            var commisionException = (ProductStockException)context.Exception;
            var errorResponse = new ResponseError(commisionException.GetErros());
            context.HttpContext.Response.StatusCode = commisionException.StatusCode;
            context.Result = new ObjectResult(errorResponse);
        }

        private void ThrowUnknownError(ExceptionContext context)
        {
            var errorResponse = new ResponseError(["erroDesconhecido"]);
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorResponse);
        }
    }
}
