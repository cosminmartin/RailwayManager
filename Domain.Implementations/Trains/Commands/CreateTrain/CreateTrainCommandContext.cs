namespace Domain.Implementations.Trains.Commands.CreateTrain
{
    public class CreateTrainCommandContext : ICreateTrainCommandContext
    {
        private readonly ITrainWriteRepository trainWriteRepository;
        private readonly IValidator<CreateTrainCommand> validator;
        
        public CreateTrainCommandContext(ITrainWriteRepository trainWriteRepository, IValidator<CreateTrainCommand> validator)
        {
            this.trainWriteRepository = trainWriteRepository;
            this.validator = validator;
        }

        public async Task<TrainDto> Execute(CreateTrainCommand command)
        {
            var validationResult = await validator.ValidateAsync(command);

            if(!validationResult.IsValid)
            {
                var failures = validationResult.Errors.Where(x => x != null).ToList();

                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var result = await trainWriteRepository.CreateTrainAsync(new CreateTrainContract(command.Name, command.DepartureStation, command.ArrivalStation, command.DepartureDate, command.ArrivalDate, command.Duration, command.Status));

            return result.ToModel().ToDto();
        }
    }
}
