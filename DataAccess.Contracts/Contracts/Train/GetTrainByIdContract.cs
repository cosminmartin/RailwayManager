namespace DataAccess.Contracts.Contracts.Train
{
    public class GetTrainByIdContract
    {
        public Guid TrainId { get; set; }

        public GetTrainByIdContract(Guid trainId)
        {
            TrainId = trainId;
        }
    }
}
