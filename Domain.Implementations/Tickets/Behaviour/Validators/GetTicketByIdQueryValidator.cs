namespace Domain.Implementations.Tickets.Behaviour.Validators
{
    public class GetTicketByIdQueryValidator : AbstractValidator<GetTicketByIdQuery>
    {
        public GetTicketByIdQueryValidator() 
        {
            RuleFor(q => q)
                .NotNull();
            RuleFor(q => q.TicketId)
                .NotEmpty().WithMessage("Ticket id is required");
        }
    }
}
