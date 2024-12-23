namespace Blog.Common.Communal;

public class ErrorResponse
{
    private const string EnglishLanguage = "en";
    private const string DutchLanguage = "nl";

    public ErrorResponse(ErrorModel error, string language = null)
    {
        Code = error.Code;
        Title = error.Title;
        Message = language switch
        {
            EnglishLanguage => error.Messages[Language.English],
            DutchLanguage => error.Messages[Language.Farsi],
            _ => error.Messages[Language.English],
        };
    }
    public int Code { get; }
    public string Title { get; }
    public string Message { get; }
}