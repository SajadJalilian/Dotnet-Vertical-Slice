namespace Blog.Common.Communal;

public record StandardApiResponse(
    bool IsSuccess,
    object? Result,
    int? ErrorCode,
    string? ErrorMessage
);