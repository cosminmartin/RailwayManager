namespace Domain.Implementations.Users.Behaviour.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator() 
        {
            RuleFor(q => q)
              .NotNull();
            RuleFor(q => q.Email)
                .NotEmpty().WithMessage("Email address is required.")
                .EmailAddress().WithMessage("A valid email address is required.")
                .Length(1, 100);
            RuleFor(q => q.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .Length(1, 256);
            RuleFor(q => q.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .Length(1, 256);
            RuleFor(q => q.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Matches(RegexConstants.PasswordRequirements).WithMessage("Password should contain at least one UpperCase letter, one number, and one special character.");
            RuleFor(q => q.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .Length(1, 15);
        }
    }
}
