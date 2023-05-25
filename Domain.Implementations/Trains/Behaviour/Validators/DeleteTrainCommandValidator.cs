namespace Domain.Implementations.Trains.Behaviour.Validators
{
    public class DeleteTrainCommandValidator : AbstractValidator<DeleteTrainCommand>
    {
        public DeleteTrainCommandValidator() 
        {
            RuleFor(q => q)
                   .NotNull();
            RuleFor(q => q.TrainId)
                .NotEmpty().WithMessage("Train Id is required");
        }
    }
}
