namespace Blog.Common.Communal;

public class OperationResult
{
    public readonly OperationResultStatus Status;
    public readonly bool IsPersistable;
    public readonly object Value;
    public readonly Dictionary<string, object> OperationValues;

    public OperationResult(OperationResultStatus status, object value,
        bool isPersistable = false, Dictionary<string, object> operationValues = null)
    {
        Status = status;
        Value = value;
        IsPersistable = isPersistable;
        OperationValues = operationValues;
    }

    public bool Succeeded => IsSucceeded(Status);

    private bool IsSucceeded(OperationResultStatus status) => status switch
    {
        _ when
            status == OperationResultStatus.Ok ||
            status == OperationResultStatus.Created => true,
        _ when
            status == OperationResultStatus.InvalidRequest ||
            status == OperationResultStatus.NotFound ||
            status == OperationResultStatus.Unauthorized ||
            status == OperationResultStatus.Unprocessable => false,
        _ => false
    };

    public OperationResult Clone() => (OperationResult)MemberwiseClone();
}