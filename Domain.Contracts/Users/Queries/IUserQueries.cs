using Domain.Contracts.Dtos.User;

namespace Domain.Contracts.Users.Queries
{
    public interface IUserQueries
    {
        Task<UserDto> GetUserAsync(GetUserByIdQuery query);
    }
}
