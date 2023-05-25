namespace Domain.Contracts.Trains.Commands.DeleteTrain
{
    public class DeleteTrainCommand
    {
        public Guid TrainId { get; private set; }
        public DeleteTrainCommand(Guid trainId)
        {
            TrainId = trainId;
        }
    }
}
