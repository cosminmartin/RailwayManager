namespace Domain.Contracts.Trains.Commands.DeleteTrain
{
    public interface IDeleteTrainCommandContext
    {
        Task Execute(DeleteTrainCommand command);
    }
}
