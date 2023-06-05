namespace Domain.Implementations.Trains.Behaviour.Validators
{
    public class GetAllTrainsQueryValidator : AbstractValidator<GetAllTrainsQuery>
    {
        public GetAllTrainsQueryValidator() 
        {
            RuleFor(q => q)
               .NotNull();
            RuleFor(q => q.DepartureStation)
                .NotEmpty().WithMessage("Departure Station is required");
            RuleFor(q => q.ArrivalStation)
                .NotEmpty().WithMessage("Arrival Station is required");
        }
    }
}
