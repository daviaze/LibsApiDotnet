using EstudosApi.Errors;
using OneOf;

namespace EstudosApi.Extensions
{
    public static class OneOfExtensions
    {
        public static bool IsSuccess<TResult>(this OneOf<TResult, ServiceError> obj) => obj.IsT0;
        public static TResult GetSuccessResult<TResult>(this OneOf<TResult, ServiceError> obj) => obj.AsT0;
        public static ServiceError GetErrorResult<TResult>(this OneOf<TResult, ServiceError> obj) => obj.AsT1;
    }
}
