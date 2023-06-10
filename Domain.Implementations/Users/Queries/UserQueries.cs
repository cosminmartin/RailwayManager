namespace Domain.Implementations.Users.Queries
{
    public class UserQueries : IUserQueries
    {
        private readonly IGetUserByIdQueryContext getUserByIdQueryContext;
        private readonly IGetUserByEmailQueryContext getUserByEmailQueryContext;

        public UserQueries(IGetUserByIdQueryContext getUserByIdQueryContext, IGetUserByEmailQueryContext getUserByEmailQueryContext)
        {
            this.getUserByIdQueryContext = getUserByIdQueryContext;
            this.getUserByEmailQueryContext = getUserByEmailQueryContext;
        }

        public async Task<UserDto> GetUserAsync(GetUserByIdQuery query)
        {
            return await getUserByIdQueryContext.Execute(query);
        }

        public async Task<UserDto> GetUserAsync(GetUserByEmailQuery query)
        {
            return await getUserByEmailQueryContext.Execute(query);
        }
    }
}
