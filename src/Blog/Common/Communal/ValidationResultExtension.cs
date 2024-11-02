namespace Blog.Common.Communal;

public static class ValidationResultExtension
{
    public static string GetFirstErrorMessage(this FluentValidation.Results.ValidationResult result)
    {
        return result.Errors.FirstOrDefault()?.ErrorMessage;
    }

    public static object GetFirstCustomState(this FluentValidation.Results.ValidationResult result)
    {
        return result.Errors.FirstOrDefault()?.CustomState;
    }
}