namespace Domain.Implementations.Trains.Commands.DeleteTrain
{
    public class DeleteTrainCommandContext : IDeleteTrainCommandContext
    {
        private readonly ITrainWriteRepository trainWriteRepository;
        private readonly ITrainReadRepository trainReadRepository;
        private readonly IValidator<DeleteTrainCommand> validator;

        public DeleteTrainCommandContext(ITrainWriteRepository trainWriteRepository, ITrainReadRepository trainReadRepository, IValidator<DeleteTrainCommand> validator)
        {
            this.trainWriteRepository = trainWriteRepository;
            this.trainReadRepository = trainReadRepository;
            this.validator = validator;
        }

        public async Task Execute(DeleteTrainCommand command)
        {
            var validationResult = await validator.ValidateAsync(command);

            if (!validationResult.IsValid)
            {
                var failures = validationResult.Errors.Where(e => e != null).ToList();

                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var train = (await trainReadRepository.GetTrainAsync(new GetTrainByIdContract(command.TrainId)))?.ToModel();

            if(train == null) 
            {
                throw new NotFoundException("The train id is not inside the database");
            }

            var trainsAffected = await trainWriteRepository.DeleteTrainAsync(new DeleteTrainContract(command.TrainId));

            if(trainsAffected == 0)
            {
                throw new BadRequestException();
            }
        }
    }
}
