
using EstudosApi.Errors;
using EstudosApi.Services.Interfaces;
using OneOf;

namespace EstudosApi.Services
{
    public class MedicoService : IService, IMedicoService
    {
        public OneOf<bool, ServiceError> Atender()
        {
            try
            {
                if (false)
                {
                    return true;
                }

                return new AtenderError();
            }
            catch(Exception ex)
            {
                return new GenericError();
            }
        }

        public void Start()
        {
            Console.WriteLine("Start Medico");
        }
    }
}
