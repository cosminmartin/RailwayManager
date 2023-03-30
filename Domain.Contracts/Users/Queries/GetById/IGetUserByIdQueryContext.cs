namespace Domain.Contracts.Users.Queries.GetById
{
    public interface IGetUserByIdQueryContext
    {
        Task<UserDto> Execute(GetUserByIdQuery query);
    }
}
