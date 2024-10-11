namespace Blog.Common.Communal;

public enum OperationResultStatus
{
    Ok = 1,
    Created,
    InvalidRequest,
    NotFound,
    Unauthorized,
    Unprocessable
}