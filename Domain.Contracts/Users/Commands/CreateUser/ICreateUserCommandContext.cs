namespace Domain.Contracts.Users.Commands.CreateUser
{
    public interface ICreateUserCommandContext
    {
        Task<UserDto> Execute(CreateUserCommand command);
    }
}
