namespace Domain.Contracts.Trains.Queries.GetAllTrains
{
    public interface IGetAllTrainsQueryContext
    {
        Task<IEnumerable<TrainDto>> Execute(GetAllTrainsQuery query);
    }
}
