namespace Domain.Contracts.Trains.Commands.EditTrain
{
    public interface IEditTrainCommandContext
    {
        Task<TrainDto> Execute(EditTrainCommand command);
    }
}
