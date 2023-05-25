namespace Domain.Implementations.Trains.Behaviour.Validators
{
    public class EditTrainCommandValidator : AbstractValidator<EditTrainCommand>
    {
        public EditTrainCommandValidator() 
        {
            RuleFor(q => q)
                    .NotNull();
        }
    }
}
