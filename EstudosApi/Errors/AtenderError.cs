namespace EstudosApi.Errors
{
    public record AtenderError() : ServiceError("Erro ao atender", "001", nameof(ServiceErrorType.Validation))
    {

    }
}
