using Domain.Contracts.Dtos.User;

namespace Domain.Implementations.Users.Queries
{
    public class UserQueries : IUserQueries
    {
        private readonly IGetUserByIdQueryContext getUserByIdQueryContext;

        public UserQueries(IGetUserByIdQueryContext getUserByIdQueryContext)
        {
            this.getUserByIdQueryContext = getUserByIdQueryContext;
        }

        public async Task<UserDto> GetUserAsync(GetUserByIdQuery query)
        {
            return await getUserByIdQueryContext.Execute(query);
        }
    }
}
