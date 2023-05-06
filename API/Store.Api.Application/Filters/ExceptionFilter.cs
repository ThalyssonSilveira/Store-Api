using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Store.Api.Application.Models.Response;
using Store.Platform.Auth.Common;
using Store.Platform.Business.Common;

namespace Store.Api.Application.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        HttpStatusCode httpStatusCode;
        var response = new Response();

        switch (context.Exception)
        {
            case BusinessException:
            case AuthException:
                httpStatusCode = HttpStatusCode.BadRequest;
                response.Message = context.Exception.Message;
                break;

            default:
                httpStatusCode = HttpStatusCode.InternalServerError;
                response.Message = "Ocorreu um erro inesperado.";
                break;
        }

        var result = new ObjectResult(response);
        result.StatusCode = (int)httpStatusCode;
        context.Result = result;
    }
}
