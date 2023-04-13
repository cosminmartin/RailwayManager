namespace Domain.Implementations.Users.Commands
{
    public class UserCommands : IUserCommands
    {
        private readonly ICreateUserCommandContext createUserContext;
        
        public UserCommands(ICreateUserCommandContext createUserContext)
        {
            this.createUserContext = createUserContext;
        }

        public async Task<UserDto> CreateUserAsync(CreateUserCommand command)
        {
            return await createUserContext.Execute(command);
        }
    }
}
