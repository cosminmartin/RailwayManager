namespace Domain.Contracts.Users.Queries.GetByEmail
{
	public interface IGetUserByEmailQueryContext
	{
		Task<UserDto> Execute(GetUserByEmailQuery query);
	}
}
