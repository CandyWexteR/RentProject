using System.Net;

namespace RentcarProj.ErrorHandling;

public class ExceptionResponse
{
    public ExceptionResponse(string message, int statusCode)
    {
        Message = message;
        StatusCode = statusCode;
    }
    public string Message { get; protected set; }
    public int StatusCode { get; protected set; }

    public static ExceptionResponse Create(string message, HttpStatusCode statusCode)
    {
        return new ExceptionResponse(message, (int)statusCode);
    }
}