namespace Domain.Implementations.Users.Behaviour.Validators
{
    public class GetUserByIdQueryValidator : AbstractValidator<GetUserByIdQuery>
    {
        public GetUserByIdQueryValidator() 
        {
            RuleFor(q => q)
                .NotNull();
            RuleFor(q => q.UserId)
                .NotEmpty().WithMessage("User id is required");
        }  
    }
}
