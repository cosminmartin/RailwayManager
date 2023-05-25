namespace Domain.Contracts.Trains.Commands
{
    public interface ITrainCommands
    {
        Task<TrainDto> CreateTrainAsync(CreateTrainCommand command);
        Task<TrainDto> EditTrainAsync(EditTrainCommand command);
        Task DeleteTrainAsync(DeleteTrainCommand command);
    }
}
