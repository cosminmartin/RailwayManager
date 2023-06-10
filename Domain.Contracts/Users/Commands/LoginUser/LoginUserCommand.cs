namespace Domain.Contracts.Users.Commands.LoginUser
{
	public class LoginUserCommand
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public LoginUserCommand(string email, string password)
		{
			Email = email;
			Password = password;
		}
	}
}
