using EstudosApi.Errors;
using OneOf;

namespace EstudosApi.Services.Interfaces
{
    public interface IMedicoService
    {
        public OneOf<bool, ServiceError> Atender();
    }
}
