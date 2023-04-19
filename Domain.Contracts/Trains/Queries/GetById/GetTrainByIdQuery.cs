namespace Domain.Contracts.Trains.Queries.GetById
{
    public class GetTrainByIdQuery
    {
        public Guid TrainId { get; set; }

        public GetTrainByIdQuery(Guid trainId) 
        { 
            TrainId = trainId;
        }
    }
}
