namespace Domain.Implementations.Tickets.Behaviour.Validators
{
    public class CreateTicketCommandValidator : AbstractValidator<CreateTicketCommand>
    {
        public CreateTicketCommandValidator() 
        {
            RuleFor(q => q)
            .NotNull();
            RuleFor(q => q.TrainId)
               .NotEmpty().WithMessage("Train id is required");
            RuleFor(q => q.UserId)
               .NotEmpty().WithMessage("User id is required");
        }
    }
}
