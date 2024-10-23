namespace EstudosApi.Errors
{
    public record ServiceError(string Description, string CodeError, string NameError)
    {
    }

    public enum ServiceErrorType
    {
        Validation,
        Generic
    }
}
