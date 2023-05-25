namespace DataAccess.Contracts.Contracts.Train
{
    public class DeleteTrainContract
    {
        public Guid TrainId { get; private set; }
        public DeleteTrainContract(Guid trainId)
        {
            TrainId = trainId;
        }
    }
}
