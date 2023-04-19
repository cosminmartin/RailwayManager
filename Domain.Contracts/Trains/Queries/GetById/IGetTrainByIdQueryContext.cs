namespace Domain.Contracts.Trains.Queries.GetById
{
    public interface IGetTrainByIdQueryContext
    {
        Task<TrainDto> Execute(GetTrainByIdQuery query);
    }
}
