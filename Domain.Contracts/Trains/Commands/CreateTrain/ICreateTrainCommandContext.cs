namespace Domain.Contracts.Trains.Commands.CreateTrain
{
    public interface ICreateTrainCommandContext
    {
        Task<TrainDto> Execute(CreateTrainCommand command);
    }
}
