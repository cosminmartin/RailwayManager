namespace Domain.Implementations.Trains.Commands.EditTrain
{
    public class EditTrainCommandContext : IEditTrainCommandContext
    {
        private readonly ITrainWriteRepository trainWriteRepository;
        private readonly ITrainReadRepository trainReadRepository;
        private readonly IValidator<EditTrainCommand> validator;

        public EditTrainCommandContext(ITrainWriteRepository trainWriteRepository, ITrainReadRepository trainReadRepository, IValidator<EditTrainCommand> validator)
        {
            this.trainWriteRepository = trainWriteRepository;
            this.trainReadRepository = trainReadRepository;
            this.validator = validator;
        }

        public async Task<TrainDto> Execute(EditTrainCommand command)
        {
            var validationResult = await validator.ValidateAsync(command);

            if (!validationResult.IsValid)
            {
                var failures = validationResult.Errors.Where(e => e != null).ToList();

                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var train = (await trainReadRepository.GetTrainAsync(new GetTrainByIdContract(command.TrainId)))?.ToModel();

            if (train == null)
            {
                throw new NotFoundException("The train id is not inside the database");
            }

            var editedTrain = await trainWriteRepository.EditTrainAsync(new EditTrainContract
                (command.TrainId,
                command.Name,
                command.DepartureStation,
                command.ArrivalStation,
                command.DepartureDate,
                command.ArrivalDate,
                command.Duration,
                command.Status
                ));

            return editedTrain.ToModel().ToDto();
        }
    }
}
