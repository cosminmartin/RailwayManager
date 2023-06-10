namespace Domain.Implementations.Users.Commands
{
    public class UserCommands : IUserCommands
    {
        private readonly ICreateUserCommandContext createUserContext;
		private readonly ILoginUserCommandContext loginUserContext;

		public UserCommands(ICreateUserCommandContext createUserContext, ILoginUserCommandContext loginUserContext)
        {
            this.createUserContext = createUserContext;
			this.loginUserContext = loginUserContext;
		}

        public async Task<UserDto> CreateUserAsync(CreateUserCommand command)
        {
            return await createUserContext.Execute(command);
        }
		public async Task<UserTokenDto> LoginUserAsync(LoginUserCommand command)
		{
			return await loginUserContext.Execute(command);
		}
	}
}
