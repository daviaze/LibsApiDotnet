namespace EstudosApi.Errors
{
    public record GenericError() : ServiceError("Erro genérico", "000", nameof(ServiceErrorType.Generic))
    {

    }
}
