namespace Domain.Contracts.Trains.Commands
{
    public interface ITrainCommands
    {
        Task<TrainDto> CreateTrainAsync(CreateTrainCommand command);
    }
}
