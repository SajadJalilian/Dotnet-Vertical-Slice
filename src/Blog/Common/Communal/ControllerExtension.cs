using Microsoft.AspNetCore.Mvc;

namespace Blog.Common.Communal;

public static class ControllerExtension
{
    public static IActionResult ReturnResponse(this ControllerBase controller, OperationResult operation)
    {
        object response = operation.Value;
        StandardApiResponse standardApiResponse;
        if (response is ErrorModel errorModel)
        {
            standardApiResponse = new StandardApiResponse(
                IsSuccess: false,
                Result: null,
                ErrorCode: errorModel.Code,
                // TODO: Get language config from settings
                ErrorMessage: errorModel.Messages[Language.Farsi]);
        }
        else
        {
            standardApiResponse = new StandardApiResponse(
                IsSuccess: true,
                Result: response,
                ErrorCode: null,
                ErrorMessage: null);
        }

        return operation.Status switch
        {
            OperationResultStatus.Ok => controller.Ok(standardApiResponse),
            OperationResultStatus.Created => controller.Created("-", standardApiResponse),
            OperationResultStatus.InvalidRequest => controller.BadRequest(standardApiResponse),
            OperationResultStatus.NotFound => controller.NotFound(standardApiResponse),
            OperationResultStatus.Unauthorized => controller.UnprocessableEntity(standardApiResponse),
            OperationResultStatus.Unprocessable => controller.UnprocessableEntity(standardApiResponse),
            _ => controller.UnprocessableEntity(standardApiResponse)
        };
    }
}