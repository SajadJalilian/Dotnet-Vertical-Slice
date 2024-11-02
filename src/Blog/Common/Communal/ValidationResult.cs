namespace Blog.Common.Communal;

public record ValidationResult(bool IsValid, object? ErrorMessage);