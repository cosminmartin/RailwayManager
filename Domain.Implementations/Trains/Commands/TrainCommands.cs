namespace Domain.Implementations.Trains.Commands
{
    public class TrainCommands : ITrainCommands
    {
        private readonly ICreateTrainCommandContext createTrainCommandContext;
        public TrainCommands(ICreateTrainCommandContext createTrainCommandContext)
        {
            this.createTrainCommandContext = createTrainCommandContext;
        }

        public async Task<TrainDto> CreateTrainAsync(CreateTrainCommand command)
        {
            return await createTrainCommandContext.Execute(command);
        }
    }
}
