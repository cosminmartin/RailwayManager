namespace Domain.Contracts.Trains.Queries
{
    public interface ITrainQueries
    {
        Task<TrainDto> GetTrainAsync(GetTrainByIdQuery query);
        Task<IEnumerable<TrainDto>> GetAllTrainsAsync(GetAllTrainsQuery query);
    }
}
