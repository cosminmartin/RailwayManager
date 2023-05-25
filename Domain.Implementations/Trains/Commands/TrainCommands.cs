namespace Domain.Implementations.Trains.Commands
{
    public class TrainCommands : ITrainCommands
    {
        private readonly ICreateTrainCommandContext createTrainCommandContext;
        private readonly IEditTrainCommandContext editTrainCommandContext;
        private readonly IDeleteTrainCommandContext deleteTrainCommandContext;

        public TrainCommands(ICreateTrainCommandContext createTrainCommandContext, IEditTrainCommandContext editTrainCommandContext, IDeleteTrainCommandContext deleteTrainCommandContext)
        {
            this.createTrainCommandContext = createTrainCommandContext;
            this.editTrainCommandContext = editTrainCommandContext;
            this.deleteTrainCommandContext = deleteTrainCommandContext;
        }

        public async Task<TrainDto> CreateTrainAsync(CreateTrainCommand command)
        {
            return await createTrainCommandContext.Execute(command);
        }

        public async Task<TrainDto> EditTrainAsync(EditTrainCommand command)
        {
            return await editTrainCommandContext.Execute(command);
        }

        public async Task DeleteTrainAsync(DeleteTrainCommand command)
        {
            await deleteTrainCommandContext.Execute(command);
        }
    }
}
