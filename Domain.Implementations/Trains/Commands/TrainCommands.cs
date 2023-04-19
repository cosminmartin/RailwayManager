using Domain.Contracts.Trains.Commands;

namespace Domain.Implementations.Trains.Commands
{
    public class TrainCommands : ITrainCommands
    {
        private readonly ICreateTrainCommandContext createTrainContext;
        public TrainCommands(ICreateTrainCommandContext createTrainContext)
        {
            this.createTrainContext = createTrainContext;
        }

        public async Task<TrainDto> CreateTrainAsync(CreateTrainCommand command)
        {
            return await createTrainContext.Execute(command);
        }


    }
}
