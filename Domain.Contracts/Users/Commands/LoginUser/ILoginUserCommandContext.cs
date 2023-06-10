namespace Domain.Contracts.Users.Commands.LoginUser
{
	public interface ILoginUserCommandContext
	{
		Task<UserTokenDto> Execute(LoginUserCommand command);
	}
}
