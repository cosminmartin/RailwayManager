namespace Domain.Contracts.Users.Commands
{
    public interface IUserCommands
    {
        Task<UserDto> CreateUserAsync(CreateUserCommand command);
    }
}
