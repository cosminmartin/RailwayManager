using Domain.Contracts.Dtos.User;

namespace Domain.Contracts.Users.Queries.GetById
{
    public interface IGetUserByIdQueryContext
    {
        Task<UserDto> Execute(GetUserByIdQuery query);
    }
}
