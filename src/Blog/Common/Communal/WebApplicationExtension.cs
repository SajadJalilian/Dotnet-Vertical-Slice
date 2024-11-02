namespace Blog.Common.Communal;

public static class WebApplicationExtension
{
    public static IResult ReturnResponse(this WebApplication app, OperationResult operation)
    {
        object response = operation.Value;
        if (response is ErrorModel errorModel)
            response = new ErrorResponse(errorModel);

        return operation.Status switch
        {
            OperationResultStatus.Ok => Results.Ok(response),
            OperationResultStatus.Created => Results.Created("-", response), // URI can not be null. I will get fixed in .NET 8
            OperationResultStatus.InvalidRequest => Results.BadRequest(response),
            OperationResultStatus.NotFound => Results.NotFound(response),
            OperationResultStatus.Unauthorized => Results.UnprocessableEntity(response),
            OperationResultStatus.Unprocessable => Results.UnprocessableEntity(response),
            _ => Results.UnprocessableEntity(response)
        };
    }
}