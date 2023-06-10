namespace Domain.Implementations.Users.Behaviour.Validators
{
	public class LoginUserCommandValidator : AbstractValidator<LoginUserCommand>
	{
		public LoginUserCommandValidator() 
		{
			RuleFor(q => q.Email)
				.NotEmpty().WithMessage("Email address is required")
				.EmailAddress().WithMessage("A valid email address is required")
				.Length(1, 100);
			RuleFor(q => q.Password)
				.NotEmpty().WithMessage("Password is required");
		}
	}
}
