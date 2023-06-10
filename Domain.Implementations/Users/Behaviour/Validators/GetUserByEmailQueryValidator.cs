namespace Domain.Implementations.Users.Behaviour.Validators
{
	public class GetUserByEmailQueryValidator : AbstractValidator<GetUserByEmailQuery>
	{
		public GetUserByEmailQueryValidator()
		{
			RuleFor(q => q)
				.NotNull();
			RuleFor(q => q.Email)
				.NotEmpty().WithMessage("User email is required");
		}
	}
}
