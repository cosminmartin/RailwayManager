namespace Domain.Implementations.Trains.Behaviour.Validators
{
    public class GetTrainByIdQueryValidator : AbstractValidator<GetTrainByIdQuery>
    {
        public GetTrainByIdQueryValidator() 
        {
            RuleFor(q => q)
                .NotNull();
            RuleFor(q => q.TrainId)
                .NotEmpty().WithMessage("Train id is required");
        }
    }
}
