namespace Domain.Implementations.Trains.Behaviour.Validators
{
    public class CreateTrainCommandValidator : AbstractValidator<CreateTrainCommand>
    {
        public CreateTrainCommandValidator() 
        {
            RuleFor(q => q)
             .NotNull();
            RuleFor(q => q.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(1, 256);
            RuleFor(q => q.DepartureStation)
                .NotEmpty().WithMessage("Departure Station is required.")
                .Length(1, 256);
            RuleFor(q => q.ArrivalStation)
                .NotEmpty().WithMessage("Arrival Station is required.")
                .Length(1, 256);
            RuleFor(q => q.DepartureDate)
                .NotEmpty().WithMessage("Departure Date is required.");
            RuleFor(q => q.ArrivalDate)
                .NotEmpty().WithMessage("Arrival Date is required.");
        }
    }
}
